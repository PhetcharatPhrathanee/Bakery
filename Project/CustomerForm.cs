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
    public partial class CustomerForm : UserControl
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void imguser_Click(object sender, EventArgs e)
        {
            var nextForm = new UserInformation();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        private void btCustomerProduct_Click(object sender, EventArgs e)
        {
            var nextForm = new CustomerProductForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        private void btCustomerOrderHistory_Click(object sender, EventArgs e)
        {
            var nextForm = new CustomerOrderHistory();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            TestMain.FrmMain.ShowControl(new LoginForm());
        }
    }
}
