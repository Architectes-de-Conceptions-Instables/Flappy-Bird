using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnExit.BackgroundImage = Properties.Resources.obutton;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnExit.BackgroundImage = Properties.Resources.rbutton;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Leave about form
            this.Close();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //Leave about form
            this.Close();
        }
    }
}
