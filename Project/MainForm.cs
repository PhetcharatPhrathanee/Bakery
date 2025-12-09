using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : UserControl
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void imguser_Click(object sender, EventArgs e)
        {
            //TestMain.FrmMain.ShowControl(new UserInformation());
            var nextForm = new UserInformation();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }
        

        private void imgreturn_Click(object sender, EventArgs e)
        {
            TestMain.FrmMain.ShowControl(new LoginForm());
        }

        private void btoder_Click(object sender, EventArgs e)
        {
            //TestMain.FrmMain.ShowControl(new OderAllForm());
            var nextForm = new OrderNewForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        private void btListrawmaterials_Click(object sender, EventArgs e)
        {
            // TestMain.FrmMain.ShowControl(new MaterialForm());
            var nextForm = new MaterialForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        private void btliststock_Click(object sender, EventArgs e)
        {
            //TestMain.FrmMain.ShowControl(new ProductForm());
            var nextForm = new ProductForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        private void btreport_Click(object sender, EventArgs e)
        {
            //  TestMain.FrmMain.ShowControl(new ReportMenuForm());
            var nextForm = new ReportMenuForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        private void pbNotificationMenu_Click(object sender, EventArgs e)
        {
            var nextForm = new NotificationMenuForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            TestMain.FrmMain.ShowControl(new LoginForm());
        }
    }
}
