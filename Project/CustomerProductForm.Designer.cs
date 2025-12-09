namespace Project
{
    partial class CustomerProductForm
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
            this.lbmtp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgreturn = new System.Windows.Forms.PictureBox();
            this.imguser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgreturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(0, 4);
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
            this.label1.Location = new System.Drawing.Point(495, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 52);
            this.label1.TabIndex = 27;
            this.label1.Text = "รายการสินค้าสำหรับเลือกซื้อ";
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
            this.imguser.Image = global::Project.Properties.Resources.cart_basket_shopping_icon_179220;
            this.imguser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imguser.Location = new System.Drawing.Point(1807, 37);
            this.imguser.Name = "imguser";
            this.imguser.Size = new System.Drawing.Size(73, 54);
            this.imguser.TabIndex = 19;
            this.imguser.TabStop = false;
            this.imguser.Click += new System.EventHandler(this.imguser_Click);
            // 
            // CustomerProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerProductForm";
            this.Size = new System.Drawing.Size(1920, 1020);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgreturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imguser)).EndInit();
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
    }
}
