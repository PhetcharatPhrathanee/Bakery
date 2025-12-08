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
            TestMain.FrmMain.ShowControl(new UserInformation());
        }

        private void imgreturn_Click(object sender, EventArgs e)
        {
            TestMain.FrmMain.ShowControl(new LoginForm());
        }

        private void btoder_Click(object sender, EventArgs e)
        {
            TestMain.FrmMain.ShowControl(new ReportOderForm());
        }

        private void btListrawmaterials_Click(object sender, EventArgs e)
        {
            TestMain.FrmMain.ShowControl(new MaterialForm());
        }

        private void btliststock_Click(object sender, EventArgs e)
        {
            TestMain.FrmMain.ShowControl(new ReportStockForm());
        }

        private void btreport_Click(object sender, EventArgs e)
        {
            TestMain.FrmMain.ShowControl(new LoginForm());
        }
    }
}
