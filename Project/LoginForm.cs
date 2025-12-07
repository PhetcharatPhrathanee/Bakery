using System;
using System.Windows.Forms;


namespace Project
{
    public partial class LoginForm : UserControl
    {
        public static LoginForm login;
        public LoginForm()
        {
            login = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ตรวจสอบ user pass ตามต้องการ
            if (txtUser.Text == "admin" && txtPass.Text == "1234")
            {
                // ไปหน้า Main
                TestMain.FrmMain.ShowControl(new MainForm());
            }
            else
            {
                MessageBox.Show("Username / Password ไม่ถูกต้อง");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
