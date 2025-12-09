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
    public partial class OderAllForm : UserControl
    {
        public UserControl PreviousControl { get; set; }
        public OderAllForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void imgreturn_Click(object sender, EventArgs e)
        {
            // TestMain.FrmMain.ShowControl(new MainForm());
            if (PreviousControl != null)
            {
                TestMain.FrmMain.ShowControl(PreviousControl);
            }
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void btcompletedorder_Click(object sender, EventArgs e)
        {

        }
    }
}
