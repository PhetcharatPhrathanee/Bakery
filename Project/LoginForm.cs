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
            txtPass.KeyDown += TxtPass_KeyDown;

        }
        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btConfirm.PerformClick();
            }
        }
        private void btConfirm_Click(object sender, EventArgs e)
        {
            // ตรวจสอบ admin
            if (txtUser.Text == "admin" && txtPass.Text == "1234")
            {
                TestMain.FrmMain.ShowControl(new MainForm());
            }
            // ตรวจสอบ user (ไปหน้า CustomerForm)
            else if (txtUser.Text == "user" && txtPass.Text == "1234")
            {
                TestMain.FrmMain.ShowControl(new CustomerForm());
            }
            else
            {
                MessageBox.Show("Username / Password ไม่ถูกต้อง");
            }
        }

        private void btRegisterForm_Click(object sender, EventArgs e)
        {
            TestMain.FrmMain.ShowControl(new RegisterForm());
        }

        private void lbRegisterForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TestMain.FrmMain.ShowControl(new RegisterForm());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           txtPass.UseSystemPasswordChar = true;
        }

        private void cbshowpass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !cbshowpass.Checked;
        }
    }
}
