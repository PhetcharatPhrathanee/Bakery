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
    public partial class OrderReadyForm : UserControl
    {
        public UserControl PreviousControl { get; set; }
        public OrderReadyForm()
        {
            InitializeComponent();
        }

        private void imgreturn_Click(object sender, EventArgs e)
        {
            if (PreviousControl != null)
            {
                TestMain.FrmMain.ShowControl(PreviousControl);
            }
        }

        private void btallorder_Click(object sender, EventArgs e)
        {
            var nextForm = new OderAllForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        private void btUnderpreparation_Click(object sender, EventArgs e)
        {
            var nextForm = new OrderDoingForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        
        private void btcompletedorder_Click(object sender, EventArgs e)
        {
            var nextForm = new OderDoneForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

        private void btcomfirmorder_Click(object sender, EventArgs e)
        {
            var nextForm = new OrderNewForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }

       
    }
}
