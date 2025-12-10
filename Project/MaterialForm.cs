using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project
{
    public partial class MaterialForm : UserControl
    {
        private byte[] selectedImageBytes = null;
        public UserControl PreviousControl { get; set; }
        public MaterialForm()
        {
            InitializeComponent();
            LoadData();
            SetupGridView();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void imgreturn_Click(object sender, EventArgs e)
        {
            if (PreviousControl != null)
            {
                TestMain.FrmMain.ShowControl(PreviousControl);
            }
        }

        private void btEditMaterial_Click(object sender, EventArgs e)
        {
            var nextForm = new EditMaterialForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

       
        

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("กรุณาเลือกแถวที่ต้องการลบ");
                return;
            }
            var result = MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่?",
                                "Confirm Delete",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["raw_material_id"].Value);

                using (var conn = new SqlConnection(
                    "Server=PS2023SCCHBMIN\\SQLEXPRESS;Database=dbBakery;Trusted_Connection=True;"))
                using (var cmd = new SqlCommand("[dbo].[Stored_material_delete]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@raw_material_id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                LoadData(); // ← ฟังก์ชันโหลดข้อมูลใหม่
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                using (var conn = new SqlConnection(
                    "Server=PS2023SCCHBMIN\\SQLEXPRESS;Database=dbBakery;Trusted_Connection=True;"))
                using (var da = new SqlDataAdapter("SELECT * FROM material", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูล: " + ex.Message);
            }
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtmaterialid.Text.Trim(), out int id))
            {
                MessageBox.Show("ID ไม่ถูกต้อง");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtmaterialname.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อวัตถุดิบ");
                return;
            }
            if (!int.TryParse(txtmaterialquantity.Text, out int qty))
            {
                MessageBox.Show("จำนวนต้องเป็นตัวเลข");
                return;
            }

            // ถ้ายังไม่มี selectedImageBytes แต่ pictureBox2 มีรูป → แปลงเป็น byte[]
            if (selectedImageBytes == null && pictureBox2.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    pictureBox2.Image.Save(ms, ImageFormat.Jpeg);
                    selectedImageBytes = ms.ToArray();
                }
            }

            using (var conn = new SqlConnection("Server=PS2023SCCHBMIN\\SQLEXPRESS;Database=dbBakery;Trusted_Connection=True;"))
            using (var cmd = new SqlCommand("Stored_material_update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@raw_material_id", id);
                cmd.Parameters.AddWithValue("@raw_material_name", txtmaterialname.Text.Trim());
                cmd.Parameters.AddWithValue("@raw_material_quantity", qty);
                cmd.Parameters.Add("@raw_material_img", SqlDbType.VarBinary).Value =
                    selectedImageBytes ?? (object)DBNull.Value;

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("แก้ไขข้อมูลสำเร็จ!");

            // 🔥 จุดที่สำคัญ: รีเฟรช DataGridView ให้จริง
            dataGridView1.DataSource = null;
            LoadData();

            // ล้าง state ค่า image หลังโหลดข้อมูลใหม่แล้ว
            selectedImageBytes = null;

            // แสดงรูปใหม่ทันทีหลังแก้ไข
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            // =============================
            // 1) ตรวจสอบข้อมูลเบื้องต้น
            // =============================

            // raw_material_id ต้องเป็นตัวเลข
            if (!int.TryParse(txtmaterialid.Text.Trim(), out int id))
            {
                MessageBox.Show("กรุณากรอก ID เป็นตัวเลข");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtmaterialname.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อวัตถุดิบ");
                return;
            }

            if (!int.TryParse(txtmaterialquantity.Text.Trim(), out int qty))
            {
                MessageBox.Show("จำนวนต้องเป็นตัวเลข");
                return;
            }

            // =============================
            // 2) ตรวจสอบ ID ซ้ำในฐานข้อมูล
            // =============================
            bool isDuplicate = false;

            using (SqlConnection conn = new SqlConnection(
                "Server=PS2023SCCHBMIN\\SQLEXPRESS;Database=dbBakery;Trusted_Connection=True;"))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT COUNT(*) FROM material WHERE raw_material_id = @id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    isDuplicate = true;
                }
            }

            if (isDuplicate)
            {
                MessageBox.Show("รหัสวัตถุดิบนี้มีอยู่ในระบบแล้ว กรุณากรอกใหม่");
                return;
            }

            // =============================
            // 3) แปลงรูปเป็น byte[] ถ้าจำเป็น
            // =============================
            if (selectedImageBytes == null && pictureBox2.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    pictureBox2.Image.Save(ms, ImageFormat.Jpeg);
                    selectedImageBytes = ms.ToArray();
                }
            }

            // =============================
            // 4) Insert ข้อมูล
            // =============================
            string query = @"INSERT INTO material 
        (raw_material_id, raw_material_name, raw_material_quantity, raw_material_img) 
        VALUES (@id, @name, @qty, @img)";

            using (SqlConnection conn = new SqlConnection(
                "Server=PS2023SCCHBMIN\\SQLEXPRESS;Database=dbBakery;Trusted_Connection=True;"))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.AddWithValue("@name", txtmaterialname.Text.Trim());
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.Add("@img", SqlDbType.VarBinary).Value =
                    selectedImageBytes ?? (object)DBNull.Value;

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("เพิ่มวัตถุดิบเรียบร้อย");

            selectedImageBytes = null;
            LoadData();
        }



        private void btimg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "เลือกไฟล์รูปภาพ";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // อ่านไฟล์เป็น byte[] ก่อน (ปลอดภัยที่สุด)
                    selectedImageBytes = File.ReadAllBytes(ofd.FileName);

                    // สร้าง Image จากสำเนา MemoryStream เพื่อให้สามารถปิดไฟล์ได้ทันที
                    using (var ms = new MemoryStream(selectedImageBytes))
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }

                    // แค่โชว์พาธใน TextBox (ถ้าต้องการ)
                    txtImagePath.Text = ofd.FileName;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSelectedData();
        }


        private void LoadSelectedData()
        {
            if (dataGridView1.CurrentRow == null) return;

            try
            {
                var drv = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (drv == null) return;

                txtmaterialid.Text = drv["raw_material_id"]?.ToString();
                txtmaterialname.Text = drv["raw_material_name"]?.ToString();
                txtmaterialquantity.Text = drv["raw_material_quantity"]?.ToString();

                if (!drv.Row.Table.Columns.Contains("raw_material_img"))
                {
                    pictureBox2.Image = null;
                    selectedImageBytes = null;
                    return;
                }

                var imgVal = drv["raw_material_img"];
                if (imgVal == DBNull.Value || imgVal == null)
                {
                    pictureBox2.Image = null;
                    selectedImageBytes = null;
                    return;
                }

                // ถ้าบันทึกเป็น byte[]
                if (imgVal is byte[] bytes && bytes.Length > 0)
                {
                    selectedImageBytes = bytes; // เก็บไว้ใช้แก้ไขต่อ
                    using (var ms = new MemoryStream(bytes))
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }
                    return;
                }

                // ถ้าเป็น string path (ยังมีปน) ให้ลองโหลดไฟล์จาก path (fallback)
                if (imgVal is string path && File.Exists(path))
                {
                    selectedImageBytes = File.ReadAllBytes(path); // เก็บเป็น bytes ด้วย
                    using (var ms = new MemoryStream(selectedImageBytes))
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }
                    return;
                }

                // ถ้าอยู่ในรูปแบบอื่น ๆ
                pictureBox2.Image = null;
                selectedImageBytes = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            txtmaterialid.Clear();
            txtmaterialname.Clear();
            txtmaterialquantity.Clear();
            txtImagePath.Clear();

            pictureBox2.Image = null;
            selectedImageBytes = null;  // เคลียร์ byte[] รูปด้วย

            txtmaterialid.Focus();
        }

        private void SetupGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
          
        }
    }
}
