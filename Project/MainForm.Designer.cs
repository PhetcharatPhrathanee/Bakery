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
            this.imgreturn = new System.Windows.Forms.PictureBox();
            this.pbNotificationMenu = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.lbmtp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imglogo = new System.Windows.Forms.PictureBox();
            this.lbwelcome = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.btreport = new System.Windows.Forms.Button();
            this.btliststock = new System.Windows.Forms.Button();
            this.btListrawmaterials = new System.Windows.Forms.Button();
            this.btoder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgreturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotificationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.imgreturn);
            this.panel1.Controls.Add(this.pbNotificationMenu);
            this.panel1.Controls.Add(this.imguser);
            this.panel1.Controls.Add(this.lbmtp);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // imgreturn
            // 
            this.imgreturn.Image = global::Project.Properties.Resources.icons8_left_50;
            resources.ApplyResources(this.imgreturn, "imgreturn");
            this.imgreturn.Name = "imgreturn";
            this.imgreturn.TabStop = false;
            // 
            // pbNotificationMenu
            // 
            this.pbNotificationMenu.Image = global::Project.Properties.Resources.icons8_bell_52;
            resources.ApplyResources(this.pbNotificationMenu, "pbNotificationMenu");
            this.pbNotificationMenu.Name = "pbNotificationMenu";
            this.pbNotificationMenu.TabStop = false;
            this.pbNotificationMenu.Click += new System.EventHandler(this.pbNotificationMenu_Click);
            // 
            // imguser
            // 
            this.imguser.Image = global::Project.Properties.Resources.icons8_user_58;
            resources.ApplyResources(this.imguser, "imguser");
            this.imguser.Name = "imguser";
            this.imguser.TabStop = false;
            this.imguser.Click += new System.EventHandler(this.imguser_Click);
            // 
            // lbmtp
            // 
            resources.ApplyResources(this.lbmtp, "lbmtp");
            this.lbmtp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(162)))));
            this.lbmtp.Name = "lbmtp";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.imglogo);
            this.panel2.Controls.Add(this.lbwelcome);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // imglogo
            // 
            resources.ApplyResources(this.imglogo, "imglogo");
            this.imglogo.Name = "imglogo";
            this.imglogo.TabStop = false;
            // 
            // lbwelcome
            // 
            resources.ApplyResources(this.lbwelcome, "lbwelcome");
            this.lbwelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(58)))));
            this.lbwelcome.Name = "lbwelcome";
            // 
            // btLogout
            // 
            this.btLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLogout.Image = global::Project.Properties.Resources.Logout_371271;
            resources.ApplyResources(this.btLogout, "btLogout");
            this.btLogout.Name = "btLogout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btreport
            // 
            this.btreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            resources.ApplyResources(this.btreport, "btreport");
            this.btreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(47)))));
            this.btreport.Image = global::Project.Properties.Resources.icons8_report_100;
            this.btreport.Name = "btreport";
            this.btreport.UseVisualStyleBackColor = false;
            this.btreport.Click += new System.EventHandler(this.btreport_Click);
            // 
            // btliststock
            // 
            this.btliststock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            resources.ApplyResources(this.btliststock, "btliststock");
            this.btliststock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(47)))));
            this.btliststock.Image = global::Project.Properties.Resources.icons8_new_product_100__1_;
            this.btliststock.Name = "btliststock";
            this.btliststock.UseVisualStyleBackColor = false;
            this.btliststock.Click += new System.EventHandler(this.btliststock_Click);
            // 
            // btListrawmaterials
            // 
            this.btListrawmaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            resources.ApplyResources(this.btListrawmaterials, "btListrawmaterials");
            this.btListrawmaterials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(47)))));
            this.btListrawmaterials.Image = global::Project.Properties.Resources.icons8_clipboard_list_100;
            this.btListrawmaterials.Name = "btListrawmaterials";
            this.btListrawmaterials.UseVisualStyleBackColor = false;
            this.btListrawmaterials.Click += new System.EventHandler(this.btListrawmaterials_Click);
            // 
            // btoder
            // 
            this.btoder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(232)))));
            resources.ApplyResources(this.btoder, "btoder");
            this.btoder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(47)))));
            this.btoder.Image = global::Project.Properties.Resources.icons8_order_100__1_;
            this.btoder.Name = "btoder";
            this.btoder.UseVisualStyleBackColor = false;
            this.btoder.Click += new System.EventHandler(this.btorder_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btreport);
            this.Controls.Add(this.btliststock);
            this.Controls.Add(this.btListrawmaterials);
            this.Controls.Add(this.btoder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgreturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotificationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imglogo)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbmtp;
        private System.Windows.Forms.PictureBox imguser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imglogo;
        private System.Windows.Forms.Label lbwelcome;
        private System.Windows.Forms.PictureBox pbNotificationMenu;
        private System.Windows.Forms.Button btoder;
        private System.Windows.Forms.Button btListrawmaterials;
        private System.Windows.Forms.Button btliststock;
        private System.Windows.Forms.Button btreport;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.PictureBox imgreturn;

        #endregion
        // private System.Windows.Forms.CheckBox checkBox1;
    }
}