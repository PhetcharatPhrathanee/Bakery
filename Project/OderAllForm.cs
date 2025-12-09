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
        public OderAllForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void imgreturn_Click(object sender, EventArgs e)
        {
            TestMain.FrmMain.ShowControl(new MainForm());
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
