namespace Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbmtp = new System.Windows.Forms.Label();
            this.imgreturn = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imglogo = new System.Windows.Forms.PictureBox();
            this.lbwelcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgreturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.imgreturn);
            this.panel1.Controls.Add(this.imguser);
            this.panel1.Controls.Add(this.lbmtp);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 118);
            this.panel1.TabIndex = 18;
            // 
            // lbmtp
            // 
            this.lbmtp.AutoSize = true;
            this.lbmtp.Font = new System.Drawing.Font("TH Kodchasal", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbmtp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(162)))));
            this.lbmtp.Location = new System.Drawing.Point(71, 15);
            this.lbmtp.Name = "lbmtp";
            this.lbmtp.Size = new System.Drawing.Size(404, 94);
            this.lbmtp.TabIndex = 2;
            this.lbmtp.Text = "เมธาพร เบเกอรี่";
            // 
            // imgreturn
            // 
            this.imgreturn.Image = global::Project.Properties.Resources.icons8_left_50;
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
            this.imguser.Location = new System.Drawing.Point(1803, 33);
            this.imguser.Name = "imguser";
            this.imguser.Size = new System.Drawing.Size(73, 54);
            this.imguser.TabIndex = 19;
            this.imguser.TabStop = false;
            this.imguser.Click += new System.EventHandler(this.imguser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.imglogo);
            this.panel2.Controls.Add(this.lbwelcome);
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 947);
            this.panel2.TabIndex = 19;
            // 
            // imglogo
            // 
            this.imglogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imglogo.Image = ((System.Drawing.Image)(resources.GetObject("imglogo.Image")));
            this.imglogo.Location = new System.Drawing.Point(90, 110);
            this.imglogo.Name = "imglogo";
            this.imglogo.Size = new System.Drawing.Size(633, 497);
            this.imglogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imglogo.TabIndex = 8;
            this.imglogo.TabStop = false;
            // 
            // lbwelcome
            // 
            this.lbwelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbwelcome.AutoSize = true;
            this.lbwelcome.Font = new System.Drawing.Font("TH Kodchasal", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbwelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(58)))));
            this.lbwelcome.Location = new System.Drawing.Point(171, 665);
            this.lbwelcome.Name = "lbwelcome";
            this.lbwelcome.Size = new System.Drawing.Size(472, 140);
            this.lbwelcome.TabIndex = 7;
            this.lbwelcome.Text = "ยินดีต้อนรับ";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("TH Kodchasal", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Size = new System.Drawing.Size(1920, 1020);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgreturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbmtp;
        private System.Windows.Forms.PictureBox imguser;
        private System.Windows.Forms.PictureBox imgreturn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imglogo;
        private System.Windows.Forms.Label lbwelcome;

        #endregion
        // private System.Windows.Forms.CheckBox checkBox1;
    }
}