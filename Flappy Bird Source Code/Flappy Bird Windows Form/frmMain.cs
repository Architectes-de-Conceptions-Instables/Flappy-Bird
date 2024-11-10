 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class frmMain : Form
    {

        //Inspired slightly by MOO ICT
        //Graphics were all basically stolen but I guess I'm a student so it's fine because Fair Use. I know some graphics were made by BrittneyAnnart and some were found on Consumed by Star Wars Feelings.

        int intSpeed = 0;
        int intGravity = 0;
        int intCountDown = 70;
        int purpleCount = 200;
        int intLives = 2;
        int intRandomNumber;
        const int intHeight = 90; //This number determines the size of the flappy bird. I would've just put it in the sizeBird method but I need smth for the constant requirement
        double dblTicks = 0;
        bool blnStart = false;
        bool blnPurp = true;
        Random random = new Random();
        public int intScore { get; set; } = 0;
        public string strLag { get; set; } = "";
        private Stopwatch stopwatch;

        public frmMain()
        {
            InitializeComponent();
            gameTimer.Stop();
            this.KeyDown += new KeyEventHandler(Form_KeyDown);

            //This form stays open the whole time. frmMenu pops open first and frmGameOver pops open last 
            this.Hide();
            frmMenu frmMenu = new frmMenu(this)
            {
                Owner = this
            };
            frmMenu.ShowDialog();
        }

        public void startGame()
        { 
            //Reset everything for gameplay

            intGravity = 0;
            intSpeed = 12; //This determines the initial speed that the lightsabers move at
            intScore = 0;
            intCountDown = 70;
            intLives = 2;
            dblTicks = 0;
            blnStart = false;
            stopwatch = new Stopwatch();
            stopwatch.Start();
            this.Focus();
            resetPositions();
            this.Show();

            //Randomly select between Obi Wan and Anakan flappy birds
            intRandomNumber = random.Next(0, 2);
            if (intRandomNumber == 1)
            {
                //Set flappy bird, background picture, and lightsabers to Anakin stuff
                setGraphics("Anakin");
            }
            else
            {
                //Set flappy bird, background picture, and lightsabers to young Obi Wan stuff
                setGraphics("Obi");
            }

            //Size flappy bird
            sizeBird();

            //Game on, man
            gameTimer.Start();
        }

        private void resetPositions()
        {
            //These numbers determine the starting positions of everything
            pipeBottom.Left = 800;
            pipeBottom2.Left = 1400;
            pipeTop.Left = 800;
            pipeTop2.Left = 1400;
            flappyBird.Left = 87;
            flappyBird.Top = 250;
            pipePurp.Left = -500;
        }

        private void setGraphics(string strPerson)
        {
            //Set flappy bird, background picture, and lightsabers
            if (strPerson == "Anakin")
            {
                //Anakin stuff
                flappyBird.Image = Properties.Resources.Ani;
                this.BackgroundImage = Properties.Resources.tusk1;
                pipeTop.Image = Properties.Resources.red2;
                pipeTop2.Image = Properties.Resources.red2;
                pipeBottom.Image = Properties.Resources.red;
                pipeBottom2.Image = Properties.Resources.red;
            }
            else if (strPerson == "Obi")
            {
                //Young Obi Wan stuff
                flappyBird.Image = Properties.Resources.Youngbi;
                this.BackgroundImage = Properties.Resources.must;
                pipeTop.Image = Properties.Resources.red2;
                pipeTop2.Image = Properties.Resources.red2;
                pipeBottom.Image = Properties.Resources.red;
                pipeBottom2.Image = Properties.Resources.red;
            }
            else if (strPerson == "Vader")
            {
                //Darth Vader stuff
                flappyBird.Image = Properties.Resources.Vader;
                this.BackgroundImage = Properties.Resources.temp1;
                pipeTop.Image = Properties.Resources.blue2;
                pipeTop2.Image = Properties.Resources.green2;
                pipeBottom.Image = Properties.Resources.green;
                pipeBottom2.Image = Properties.Resources.blue;
            }
            else
            {
                //Old Obi Wan stuff
                flappyBird.Image = Properties.Resources.wan;
                this.BackgroundImage = Properties.Resources.tatooi;
                pipeTop.Image = Properties.Resources.green2;
                pipeTop2.Image = Properties.Resources.blue2;
                pipeBottom.Image = Properties.Resources.blue;
                pipeBottom2.Image = Properties.Resources.green;
            }
        }

        private void sizeBird()
        {
            //Size flappy bird
            flappyBird.Height = intHeight;
            flappyBird.Width = (int)(flappyBird.Height * (double)flappyBird.Image.Width / flappyBird.Image.Height);
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            //Space key does jumping
            if (e.KeyCode == Keys.Space)
            {  
                blnStart = true;
                intGravity = -20; //This number determines the strength of the jump
            }  
        }       

        private void endGame()
        {
            //Game over when the guy touches something
            gameTimer.Stop();

            //I got so annoyed by the lag that I made a lag meter to tell me how much slower in percentage the game is than it should be if it ran properly.
            strLag = getLag();
            this.Hide();

            //Open frmGameOver
            frmGameOver frmGameOver = new frmGameOver(this)
            {
                Owner = this
            };
            frmGameOver.ShowDialog();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            //This is the heart of the game. The heartbeat is 40 ms/25 hz and can be found somewhere in the frmMain.Designer.cs
            //A live lag meter with timers. Timer according to the game, every 25 25hz gameTimerEvents is a second, and a timer based on system clock.
            lblLag.Text = "LAG: " + getLag();
            lblTimer.Text = "REAL TIMER: " + stopwatch.Elapsed.TotalSeconds.ToString("F2");
            lblLoadTimer.Text = "LOAD TIMER: " + (dblTicks / 25).ToString("F2");
            dblTicks++;

            //Update score
            scoreText.Text = "Score: " + intScore;

            //Big text

            int x = (this.ClientSize.Width - lblCount.Width) / 2;
            int y = (this.ClientSize.Height - lblCount.Height) / 2;
            if (blnStart == false && intLives == 2)
            {
                //This makes the press space text that goes away when you press space
                    lblCount.Text = "PRess SpAce";
                intCountDown++;
                lblCount.Location = new Point(x, y);
                lblCount.Visible = true;
                lblCount.Enabled = true;
            }
            else if (intCountDown < 60)
            {
                //This makes the 1 life remains text that goes away after you press space or after a timer, in which case the gravity is reset
                    lblCount.Text = "1 Life rEmains.";
                intCountDown++;
                lblCount.Location = new Point(x, y);
                lblCount.Visible = true;
                lblCount.Enabled = true;
                if (blnStart == true)
                    intCountDown = 70;
                else
                    intGravity = 0;
            }
            else
            {
                //Actual gameplay
                //Hide big text
                lblCount.Visible = false;
                lblCount.Enabled = false; //Disable lblCount for literally no reason. I can't think of a use for that in this game

                //The flappy bird and the lightsabers move
                flappyBird.Top += intGravity;
                pipeBottom.Left -= intSpeed;
                pipeTop.Left -= intSpeed;
                pipeBottom2.Left -= intSpeed;
                pipeTop2.Left -= intSpeed;
                if (intScore < 30)
                    //Purple lightsaber moves quickly
                    pipePurp.Left -= intSpeed * 4;
                else
                    //But not too quickly
                    pipePurp.Left -= intSpeed * 2;
                if (intGravity < 20) //This number determines the cutoff for gravity strength to keep the poor guy from getting sucked into the ground
                    //Gravity moves quickly
                    intGravity += 3; //This number determines gravity strength
                else
                    //But not too quickly
                    intGravity += 1; //This number determines gravity strength after cutoff
                 
                if (purpleCount == 0)
                {
                    //Purple lightsaber goes off after a randomly set timer
                    //The graphic is flipped every time
                    if (blnPurp == true)
                    {
                        pipePurp.Image = Properties.Resources.purple;
                        blnPurp = false;
                    }
                    else
                    {
                        pipePurp.Image = Properties.Resources.purple2;
                        blnPurp = true;
                    } 

                    //Randomly reset counter
                    purpleCount = random.Next(80, 140);
                    pipePurp.Left = 1500;
                    intScore++;
                }
                else
                    //Count down for purple lightsaber
                    purpleCount--;

                //Reset 2 of the pipes in random positions
                int intPipe = random.Next(1200, 1600);

                if (pipeBottom.Left < -150)
                {
                    pipeBottom.Left = 1400; //For two of the if statements, this number determines where two of the lightsabers reset
                    intScore++; //For the four if statements, every time a lightsaber passes, score increases
                    if (intScore < 60) //For the four if statements, this number determines when the speed stops increasing
                        intSpeed++;
                }
                if (pipeTop.Left < -150)
                {
                    pipeTop.Left = intPipe;
                    intScore++;
                    if (intScore < 60)
                        intSpeed++;
                }
                if (pipeBottom2.Left < -150)
                {
                    pipeBottom2.Left = 1400;
                    intScore++;
                    if (intScore < 6)
                        if (intScore < 60)
                            intSpeed++;
                }
                if (pipeTop2.Left < -150)
                {
                    pipeTop2.Left = intPipe;
                    intScore++;
                    if (intScore < 60)
                    intSpeed++;
                }

                //Here I will admit the code is too simple. This allows it so that when the transparent corners of the flappy bird and the lightsaber picture boxes touch, he dies, which is unfair, but fixing this comes with sophisticated issues--namely that the picture boxes don't actually have transparent pixels, they literally just adopt the color of the form's background image, making it impossible to discern between head/lightsaber and invisible corner.
                if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(pipePurp.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(picTop.Bounds))
                {
                    //In the event that the flappy bird touches anything, lose 1 life and get another chance as an older version of the character, lose another and the game ends
                    intLives--;
                    lblLives.Text = "Lives: " + intLives;

                    //Reset countdown for 1 life left text
                    intCountDown = 0;
                    blnStart = false;
                    if (intRandomNumber == 1)
                    {
                        //Set flappy bird, background picture, and lightsabers to Darth Vader stuff
                        setGraphics("Vader");
                    }
                    else
                    {
                        //Set flappy bird, background picture, and lightsabers to old Obi Wan stuff
                        setGraphics("Wan");
                    }

                    //Size flappy bird
                    sizeBird();

                    //Reset positions
                    resetPositions();

                    if (intLives == 0)
                        //If game over, game over
                        endGame();
                }
            }
        }

        private string getLag()
        {
            //A value returning method that calculates the lag and returns it as a string. The calculations are neccesary but it really doesn't need to be in a method
            return (1 - dblTicks / 25 / stopwatch.Elapsed.TotalSeconds).ToString("P2");
        }
    }
}
