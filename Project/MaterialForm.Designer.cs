namespace Project
{
    partial class MaterialForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgreturn = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.lbmtp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEditMaterial = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.txtmaterialid = new System.Windows.Forms.TextBox();
            this.txtmaterialquantity = new System.Windows.Forms.TextBox();
            this.txtmaterialname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btimg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btclear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgreturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.imgreturn);
            this.panel1.Controls.Add(this.imguser);
            this.panel1.Controls.Add(this.lbmtp);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1923, 118);
            this.panel1.TabIndex = 22;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.icons8_bell_52;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(1708, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // imgreturn
            // 
            this.imgreturn.Image = global::Project.Properties.Resources.icons8_left_50;
            this.imgreturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgreturn.Location = new System.Drawing.Point(22, 33);
            this.imgreturn.Name = "imgreturn";
            this.imgreturn.Size = new System.Drawing.Size(53, 54);
            this.imgreturn.TabIndex = 20;
            this.imgreturn.TabStop = false;
            this.imgreturn.Click += new System.EventHandler(this.imgreturn_Click);
            // 
            // imguser
            // 
            this.imguser.Image = global::Project.Properties.Resources.icons8_user_58;
            this.imguser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imguser.Location = new System.Drawing.Point(1803, 33);
            this.imguser.Name = "imguser";
            this.imguser.Size = new System.Drawing.Size(73, 54);
            this.imguser.TabIndex = 19;
            this.imguser.TabStop = false;
            // 
            // lbmtp
            // 
            this.lbmtp.AutoSize = true;
            this.lbmtp.Font = new System.Drawing.Font("TH Kodchasal", 48F, System.Drawing.FontStyle.Bold);
            this.lbmtp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(162)))));
            this.lbmtp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbmtp.Location = new System.Drawing.Point(71, 15);
            this.lbmtp.Name = "lbmtp";
            this.lbmtp.Size = new System.Drawing.Size(404, 94);
            this.lbmtp.TabIndex = 2;
            this.lbmtp.Text = "เมธาพร เบเกอรี่";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH Kodchasal", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 52);
            this.label1.TabIndex = 25;
            this.label1.Text = "รายการวัตถุดิบ";
            // 
            // btEditMaterial
            // 
            this.btEditMaterial.Location = new System.Drawing.Point(1257, 143);
            this.btEditMaterial.Name = "btEditMaterial";
            this.btEditMaterial.Size = new System.Drawing.Size(187, 77);
            this.btEditMaterial.TabIndex = 26;
            this.btEditMaterial.Text = "จัดการวัตถุดิบ";
            this.btEditMaterial.UseVisualStyleBackColor = true;
            this.btEditMaterial.Click += new System.EventHandler(this.btEditMaterial_Click);
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Location = new System.Drawing.Point(964, 302);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(115, 61);
            this.btadd.TabIndex = 27;
            this.btadd.Text = "เพิ่ม";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdelete.Location = new System.Drawing.Point(964, 376);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(115, 61);
            this.btdelete.TabIndex = 28;
            this.btdelete.Text = "ลบ";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btedit
            // 
            this.btedit.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btedit.Location = new System.Drawing.Point(964, 447);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(115, 61);
            this.btedit.TabIndex = 29;
            this.btedit.Text = "แก้ไข";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // txtmaterialid
            // 
            this.txtmaterialid.Font = new System.Drawing.Font("TH Kodchasal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaterialid.Location = new System.Drawing.Point(475, 277);
            this.txtmaterialid.Name = "txtmaterialid";
            this.txtmaterialid.Size = new System.Drawing.Size(262, 43);
            this.txtmaterialid.TabIndex = 30;
            // 
            // txtmaterialquantity
            // 
            this.txtmaterialquantity.Font = new System.Drawing.Font("TH Kodchasal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaterialquantity.Location = new System.Drawing.Point(475, 427);
            this.txtmaterialquantity.Name = "txtmaterialquantity";
            this.txtmaterialquantity.Size = new System.Drawing.Size(262, 43);
            this.txtmaterialquantity.TabIndex = 31;
            // 
            // txtmaterialname
            // 
            this.txtmaterialname.Font = new System.Drawing.Font("TH Kodchasal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaterialname.Location = new System.Drawing.Point(475, 348);
            this.txtmaterialname.Name = "txtmaterialname";
            this.txtmaterialname.Size = new System.Drawing.Size(262, 43);
            this.txtmaterialname.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH Kodchasal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 41);
            this.label2.TabIndex = 33;
            this.label2.Text = "รหัสวัตถุดิบ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("TH Kodchasal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 41);
            this.label3.TabIndex = 34;
            this.label3.Text = "ชื่อวัตถุดิบ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("TH Kodchasal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 41);
            this.label4.TabIndex = 35;
            this.label4.Text = "ปริมาณวัตถุดิบ";
            // 
            // btimg
            // 
            this.btimg.Font = new System.Drawing.Font("TH Kodchasal", 20.25F, System.Drawing.FontStyle.Bold);
            this.btimg.Location = new System.Drawing.Point(475, 510);
            this.btimg.Name = "btimg";
            this.btimg.Size = new System.Drawing.Size(211, 51);
            this.btimg.TabIndex = 36;
            this.btimg.Text = "เลือกรูปภาพ";
            this.btimg.UseVisualStyleBackColor = true;
            this.btimg.Click += new System.EventHandler(this.btimg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(510, 639);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1033, 363);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(103, 639);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(303, 363);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Font = new System.Drawing.Font("TH Kodchasal", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagePath.Location = new System.Drawing.Point(475, 590);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(262, 43);
            this.txtImagePath.TabIndex = 39;
            // 
            // btclear
            // 
            this.btclear.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclear.Location = new System.Drawing.Point(964, 527);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(115, 61);
            this.btclear.TabIndex = 40;
            this.btclear.Text = "ล้างข้อมูล";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btimg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmaterialname);
            this.Controls.Add(this.txtmaterialquantity);
            this.Controls.Add(this.txtmaterialid);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btEditMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "MaterialForm";
            this.Size = new System.Drawing.Size(1920, 1020);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgreturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgreturn;
        private System.Windows.Forms.PictureBox imguser;
        private System.Windows.Forms.Label lbmtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEditMaterial;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.TextBox txtmaterialid;
        private System.Windows.Forms.TextBox txtmaterialquantity;
        private System.Windows.Forms.TextBox txtmaterialname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btimg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btclear;
    }
}
