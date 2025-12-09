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
    public partial class UserInformation : UserControl
    {
        public UserControl PreviousControl { get; set; }
        public UserInformation()
        {
            InitializeComponent();
        }

        private void lbpass_Click(object sender, EventArgs e)
        {

        }

        private void cbshowpass2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imgreturn_Click(object sender, EventArgs e)
        {
            if (PreviousControl != null)
            {
                TestMain.FrmMain.ShowControl(PreviousControl);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pbNotificationMenu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
