namespace Flappy_Bird_Windows_Form
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.pipePurp = new System.Windows.Forms.PictureBox();
            this.lblLag = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblLoadTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipePurp)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Black;
            this.scoreText.Font = new System.Drawing.Font("Star Jedi", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.White;
            this.scoreText.Location = new System.Drawing.Point(528, 612);
            this.scoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(253, 71);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flappyBird.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.wan;
            this.flappyBird.Location = new System.Drawing.Point(87, 192);
            this.flappyBird.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(129, 125);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flappyBird.TabIndex = 2;
            this.flappyBird.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.DimGray;
            this.ground.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.bottom;
            this.ground.Location = new System.Drawing.Point(-12, 612);
            this.ground.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1467, 168);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.red;
            this.pipeBottom.Location = new System.Drawing.Point(816, 412);
            this.pipeBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(44, 209);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.red2;
            this.pipeTop.Location = new System.Drawing.Point(1197, -14);
            this.pipeTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(45, 209);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeTop.TabIndex = 0;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.BackColor = System.Drawing.Color.Transparent;
            this.pipeBottom2.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.red;
            this.pipeBottom2.Location = new System.Drawing.Point(1023, 412);
            this.pipeBottom2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.Size = new System.Drawing.Size(44, 209);
            this.pipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeBottom2.TabIndex = 5;
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop2
            // 
            this.pipeTop2.BackColor = System.Drawing.Color.Transparent;
            this.pipeTop2.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.red2;
            this.pipeTop2.Location = new System.Drawing.Point(692, -14);
            this.pipeTop2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.Size = new System.Drawing.Size(44, 209);
            this.pipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipeTop2.TabIndex = 6;
            this.pipeTop2.TabStop = false;
            // 
            // picTop
            // 
            this.picTop.BackColor = System.Drawing.Color.DimGray;
            this.picTop.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.top;
            this.picTop.Location = new System.Drawing.Point(-168, -138);
            this.picTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(1467, 168);
            this.picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTop.TabIndex = 7;
            this.picTop.TabStop = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Star Jedi", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(224, 211);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(940, 192);
            this.lblCount.TabIndex = 8;
            this.lblCount.Text = "PRess SpAce";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.BackColor = System.Drawing.Color.Black;
            this.lblLives.Font = new System.Drawing.Font("Star Jedi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(1059, 622);
            this.lblLives.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(183, 58);
            this.lblLives.TabIndex = 9;
            this.lblLives.Text = "Lives: 2";
            // 
            // pipePurp
            // 
            this.pipePurp.BackColor = System.Drawing.Color.Transparent;
            this.pipePurp.Image = ((System.Drawing.Image)(resources.GetObject("pipePurp.Image")));
            this.pipePurp.Location = new System.Drawing.Point(1090, 359);
            this.pipePurp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pipePurp.Name = "pipePurp";
            this.pipePurp.Size = new System.Drawing.Size(209, 44);
            this.pipePurp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pipePurp.TabIndex = 10;
            this.pipePurp.TabStop = false;
            // 
            // lblLag
            // 
            this.lblLag.AutoSize = true;
            this.lblLag.BackColor = System.Drawing.Color.Black;
            this.lblLag.Font = new System.Drawing.Font("Alef", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLag.ForeColor = System.Drawing.Color.White;
            this.lblLag.Location = new System.Drawing.Point(48, 609);
            this.lblLag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLag.Name = "lblLag";
            this.lblLag.Size = new System.Drawing.Size(159, 49);
            this.lblLag.TabIndex = 12;
            this.lblLag.Text = "LAG: 0%";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Black;
            this.lblTimer.Font = new System.Drawing.Font("Alef", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(403, 683);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(333, 49);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "REAL TIMER: 0:00";
            // 
            // lblLoadTimer
            // 
            this.lblLoadTimer.AutoSize = true;
            this.lblLoadTimer.BackColor = System.Drawing.Color.Black;
            this.lblLoadTimer.Font = new System.Drawing.Font("Alef", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadTimer.ForeColor = System.Drawing.Color.White;
            this.lblLoadTimer.Location = new System.Drawing.Point(48, 669);
            this.lblLoadTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoadTimer.Name = "lblLoadTimer";
            this.lblLoadTimer.Size = new System.Drawing.Size(341, 49);
            this.lblLoadTimer.TabIndex = 14;
            this.lblLoadTimer.Text = "LOAD TIMER: 0:00";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.tusk1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblLoadTimer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblLag);
            this.Controls.Add(this.pipePurp);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.picTop);
            this.Controls.Add(this.pipeTop2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I\'m pretty sure it\'s supposed to be Flappy Bird?";
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipePurp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.PictureBox pipePurp;
        private System.Windows.Forms.Label lblLag;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblLoadTimer;
    }
}

