
namespace Flappy_Bird_Windows_Form
{
    partial class frmGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameOver));
            this.lblGame = new System.Windows.Forms.Label();
            this.lblOver = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLag = new System.Windows.Forms.Label();
            this.btnHigh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Transparent;
            this.lblGame.Font = new System.Drawing.Font("Star Jedi", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.ForeColor = System.Drawing.Color.Gold;
            this.lblGame.Location = new System.Drawing.Point(66, 60);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(208, 92);
            this.lblGame.TabIndex = 0;
            this.lblGame.Text = "gAme";
            // 
            // lblOver
            // 
            this.lblOver.AutoSize = true;
            this.lblOver.BackColor = System.Drawing.Color.Transparent;
            this.lblOver.Font = new System.Drawing.Font("Star Jedi", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOver.ForeColor = System.Drawing.Color.Gold;
            this.lblOver.Location = new System.Drawing.Point(699, 60);
            this.lblOver.Name = "lblOver";
            this.lblOver.Size = new System.Drawing.Size(212, 92);
            this.lblOver.TabIndex = 1;
            this.lblOver.Text = "over";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.bbutton;
            this.btnRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestart.FlatAppearance.BorderSize = 0;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Star Jedi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Gold;
            this.btnRestart.Location = new System.Drawing.Point(228, 237);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(117, 46);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "rEstart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            this.btnRestart.MouseEnter += new System.EventHandler(this.btnRestart_MouseEnter);
            this.btnRestart.MouseLeave += new System.EventHandler(this.btnRestart_MouseLeave);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.rbutton;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Star Jedi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Gold;
            this.btnQuit.Location = new System.Drawing.Point(646, 237);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(117, 46);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            this.btnQuit.MouseEnter += new System.EventHandler(this.btnQuit_MouseEnter);
            this.btnQuit.MouseLeave += new System.EventHandler(this.btnQuit_MouseLeave);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Star Jedi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(738, 169);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(139, 39);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblLag
            // 
            this.lblLag.AutoSize = true;
            this.lblLag.BackColor = System.Drawing.Color.Transparent;
            this.lblLag.Font = new System.Drawing.Font("Alef", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLag.ForeColor = System.Drawing.Color.White;
            this.lblLag.Location = new System.Drawing.Point(102, 165);
            this.lblLag.Name = "lblLag";
            this.lblLag.Size = new System.Drawing.Size(141, 43);
            this.lblLag.TabIndex = 5;
            this.lblLag.Text = "LAG: 0%";
            // 
            // btnHigh
            // 
            this.btnHigh.BackColor = System.Drawing.Color.Transparent;
            this.btnHigh.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.rbutton;
            this.btnHigh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHigh.FlatAppearance.BorderSize = 0;
            this.btnHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHigh.Font = new System.Drawing.Font("Star Jedi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHigh.ForeColor = System.Drawing.Color.Gold;
            this.btnHigh.Location = new System.Drawing.Point(725, 21);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(164, 46);
            this.btnHigh.TabIndex = 6;
            this.btnHigh.Text = "High Scores";
            this.btnHigh.UseVisualStyleBackColor = false;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            this.btnHigh.MouseEnter += new System.EventHandler(this.btnHigh_MouseEnter);
            this.btnHigh.MouseLeave += new System.EventHandler(this.btnHigh_MouseLeave);
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.burn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(978, 301);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.lblLag);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblOver);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(978, 1000);
            this.Name = "frmGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGameOver";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGameOver_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblOver;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLag;
        private System.Windows.Forms.Button btnHigh;
    }
}