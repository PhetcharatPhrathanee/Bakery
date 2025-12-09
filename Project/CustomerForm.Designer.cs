namespace Project
{
    partial class CustomerForm
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
            this.pbNotificationMenu = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.lbmtp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCustomerProduct = new System.Windows.Forms.Button();
            this.btCustomerOrderHistory = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotificationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(60)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.pbNotificationMenu);
            this.panel1.Controls.Add(this.imguser);
            this.panel1.Controls.Add(this.lbmtp);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 118);
            this.panel1.TabIndex = 19;
            // 
            // pbNotificationMenu
            // 
            this.pbNotificationMenu.Image = global::Project.Properties.Resources.icons8_bell_52;
            this.pbNotificationMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbNotificationMenu.Location = new System.Drawing.Point(1708, 37);
            this.pbNotificationMenu.Name = "pbNotificationMenu";
            this.pbNotificationMenu.Size = new System.Drawing.Size(52, 52);
            this.pbNotificationMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNotificationMenu.TabIndex = 21;
            this.pbNotificationMenu.TabStop = false;
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
            this.imguser.Click += new System.EventHandler(this.imguser_Click);
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
            this.label1.Location = new System.Drawing.Point(992, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 52);
            this.label1.TabIndex = 26;
            this.label1.Text = "หน้าหลักลูกค้า";
            // 
            // btCustomerProduct
            // 
            this.btCustomerProduct.Location = new System.Drawing.Point(961, 277);
            this.btCustomerProduct.Name = "btCustomerProduct";
            this.btCustomerProduct.Size = new System.Drawing.Size(129, 84);
            this.btCustomerProduct.TabIndex = 27;
            this.btCustomerProduct.Text = "รายการสินค้า";
            this.btCustomerProduct.UseVisualStyleBackColor = true;
            this.btCustomerProduct.Click += new System.EventHandler(this.btCustomerProduct_Click);
            // 
            // btCustomerOrderHistory
            // 
            this.btCustomerOrderHistory.Location = new System.Drawing.Point(961, 384);
            this.btCustomerOrderHistory.Name = "btCustomerOrderHistory";
            this.btCustomerOrderHistory.Size = new System.Drawing.Size(128, 84);
            this.btCustomerOrderHistory.TabIndex = 28;
            this.btCustomerOrderHistory.Text = "ประวัติคำสั่งซื้อ";
            this.btCustomerOrderHistory.UseVisualStyleBackColor = true;
            this.btCustomerOrderHistory.Click += new System.EventHandler(this.btCustomerOrderHistory_Click);
            // 
            // btLogout
            // 
            this.btLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLogout.Image = global::Project.Properties.Resources.Logout_371271;
            this.btLogout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btLogout.Location = new System.Drawing.Point(1507, 573);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(93, 115);
            this.btLogout.TabIndex = 29;
            this.btLogout.Text = "Logout";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btCustomerOrderHistory);
            this.Controls.Add(this.btCustomerProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.Size = new System.Drawing.Size(1920, 1020);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotificationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbNotificationMenu;
        private System.Windows.Forms.PictureBox imguser;
        private System.Windows.Forms.Label lbmtp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCustomerProduct;
        private System.Windows.Forms.Button btCustomerOrderHistory;
        private System.Windows.Forms.Button btLogout;
    }
}
