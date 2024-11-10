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
    public partial class frmMenu : Form
    {
         
        private frmMain _frmMain;
        bool blnPlay = false;

        public frmMenu(frmMain frmMain)
        {
            //Get method from frmMain
            InitializeComponent();
            _frmMain = frmMain;
            picturePositions();
        }

        private void picturePositions()
        {
            //Randomly select a background image from 3 choices, set the form size to equal the size of the image, and put the buttons in the right spots
            //Pick image
            Random random = new Random();
            int intRandom = random.Next(0, 3);
            if (intRandom == 1)
                picBack.Image = Properties.Resources.alsoVader;
            else if (intRandom == 2)
                picBack.Image = Properties.Resources.download;
             
            //Size form
            this.Size = new Size(picBack.Image.Size.Width, picBack.Image.Size.Height);

            //Position Restart button
            btnPlay.Location = new Point((this.ClientSize.Width - btnPlay.Width) / 2, (this.ClientSize.Height - btnPlay.Height) / 2);

            //Position Cancel button
            btnCancel.Left = this.ClientSize.Width - btnCancel.Width - 10;
            btnCancel.Top = this.ClientSize.Height - btnCancel.Height - 10;

            //Position About button
            btnAbout.Left = 10;
            btnAbout.Top = this.ClientSize.Height - btnAbout.Height - 10;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnCancel.BackgroundImage = Properties.Resources.obutton;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnCancel.BackgroundImage = Properties.Resources.rbutton;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close all forms
            Application.Exit();
        }

        private void btnPlay_MouseEnter(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnPlay.BackgroundImage = Properties.Resources.obutton;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnPlay.BackgroundImage = Properties.Resources.bbutton;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Start the game and close this form
            _frmMain.startGame();
            blnPlay = true;
            this.Close();
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnAbout.BackgroundImage = Properties.Resources.obutton;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnAbout.BackgroundImage = Properties.Resources.rbutton;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //Open about form
            frmAbout frmAbout = new frmAbout
            {
                Owner = this
            };
            frmAbout.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Close all forms if not starting game
            if (blnPlay == false)
                Application.Exit();
        }

        private void mnuPlay_Click(object sender, EventArgs e)
        {
            //Start the game and close this form
            _frmMain.startGame();
            blnPlay = true;
            this.Close();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //Open about form
            frmAbout frmAbout = new frmAbout
            {
                Owner = this
            };
            frmAbout.Show();
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            //Close all forms
            Application.Exit();
        }
    }
}
