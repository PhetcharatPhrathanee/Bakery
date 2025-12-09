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
    public partial class ProductForm : UserControl
    {
        public UserControl PreviousControl { get; set; }
        public ProductForm()
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

        private void btEditProduct_Click(object sender, EventArgs e)
        {
            var nextForm = new EditProductForm();
            nextForm.PreviousControl = this;   // ส่งหน้าปัจจุบันเข้าไปให้รู้ว่ามาจากไหน

            TestMain.FrmMain.ShowControl(nextForm);
        }
    }
}
