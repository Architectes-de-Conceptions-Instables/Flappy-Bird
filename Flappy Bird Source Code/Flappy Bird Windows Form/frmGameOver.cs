using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Flappy_Bird_Windows_Form
{
    public partial class frmGameOver : Form
    {
        private frmMain _frmMain;
        bool blnPlay = false;
        String[] strScore = new String[4];
        String[] strName = new String[4];

        public frmGameOver(frmMain frmMain)
        {
            //Size form and use variables and method from frmMain
            InitializeComponent();
            _frmMain = frmMain;
            int intScore = _frmMain.intScore;
            string strlag = _frmMain.strLag;

            //Score label
            lblScore.Text = "score: " + intScore.ToString();

            //Lag label
            lblLag.Text = "LAG: " + strlag;
             
            //Size form
            this.Size = new Size(978, BackgroundImage.Size.Height * 978 / BackgroundImage.Size.Width);

            //Read high scores file and update high scores
            fileRead();
            scoreCheck();
        }

        private void fileRead()
        {
            //Read high score file and put the data in an array
            //Read file
            StreamReader inFile;
            int intReadCount = 0;
            inFile = File.OpenText("scores.txt");
            //Put in array
            while (!inFile.EndOfStream)
            {
                strScore[intReadCount] = inFile.ReadLine();
                strName[intReadCount] = inFile.ReadLine();
                intReadCount++;
            }
            //Close file
            inFile.Close();
        }

        private void scoreCheck()
        {
            //Ask user for name and override a current high score if user gets a higher score. This is not actually how high scores work but it's good enough, nothing other than the 1st place ever mattered anyway.
            bool blnCancel = false;
            for (int i = 0; i < 3; i++)
            {
                //Check all 3 high scores
                if (blnCancel == false)
                    //Avoid overriding all the high scores
                    if (_frmMain.intScore > int.Parse(strScore[i]))
                    {
                        bool blnDigit = true;
                        object objInput = "";
                        string strInput = "";
                        string strInput2 = "";
                        blnCancel = true;

                        while (blnDigit == true)
                        {
                            //Endlessly pester user until they provide a name with no numbers
                            blnDigit = false;
                            strInput = Interaction.InputBox("Congratulations! You got the high score! You beat " + strName[i] + " with score " + strScore[i] + ". Please enter your name:", "High Score!!!", "John Smith. NO NUMBERS!");

                            //Validate input
                            foreach (char c in strInput)
                            {
                                if (Char.IsDigit(c))
                                    blnDigit = true;
                            }
                            if (blnDigit == true)
                                MessageBox.Show("NO NUMBERS ALLOWED FOR SOME REASON! Goodness");
                            if (string.IsNullOrEmpty(strInput))
                            {
                                MessageBox.Show("Put something in, man.");
                                blnDigit = true;
                            }
                        }

                        //Convert entered data into another data type (and back) for literally no reason
                        objInput = strInput;
                        strInput2 = objInput.ToString();

                        //Rewrite high scores file with new high score
                        strScore[i] = _frmMain.intScore.ToString();
                        strName[i] = strInput2;
                        StreamWriter outFile;
                        outFile = File.CreateText("scores.txt");
                        for (int a = 0; a < 3; a++)
                        {
                            outFile.WriteLine(strScore[a]);
                            outFile.WriteLine(strName[a]);
                        }
                        outFile.Close();

                        //Reread the file for accurate high score reporting
                        fileRead();
                    }
            }
        }

        private void btnRestart_MouseEnter(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnRestart.BackgroundImage = Properties.Resources.obutton;
        }

        private void btnRestart_MouseLeave(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnRestart.BackgroundImage = Properties.Resources.bbutton;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        { 
            //Restart the game and close this form
            _frmMain.startGame();
            blnPlay = true;
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Close all forms
            Application.Exit();
        }

        private void btnQuit_MouseEnter(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnQuit.BackgroundImage = Properties.Resources.obutton;
        }

        private void btnQuit_MouseLeave(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnQuit.BackgroundImage = Properties.Resources.rbutton;
        }

        private void btnHigh_MouseEnter(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnHigh.BackgroundImage = Properties.Resources.obutton;
        }

        private void btnHigh_MouseLeave(object sender, EventArgs e)
        {
            //Mouse hover effect
            btnHigh.BackgroundImage = Properties.Resources.rbutton;
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            MessageBox.Show(strName[0] + ": " + strScore[0] + "\n" + strName[1] + ": " + strScore[1] + "\n" + strName[2] + ": " + strScore[2]);
        }

        private void frmGameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close all forms if not restarting game
            if (blnPlay == false)
                Application.Exit();
        }
    }
}
