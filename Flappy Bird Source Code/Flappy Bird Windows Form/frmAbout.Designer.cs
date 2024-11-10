namespace Flappy_Bird_Windows_Form
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblAbout = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.uselessButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notHumanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstHuman = new System.Windows.Forms.ListBox();
            this.radHuman = new System.Windows.Forms.RadioButton();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.lblUseless = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(87, 357);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(452, 128);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.Text = "I\'m Alex. I made this game, I guess. Please give me a job. I need career. This ga" +
    "me is a lot easier to play than to make.";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.rbutton;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Star Jedi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(247, 520);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.itis;
            this.pictureBox1.Location = new System.Drawing.Point(-24, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 639);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.uselessButtonsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(141, 34);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // uselessButtonsToolStripMenuItem
            // 
            this.uselessButtonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.humanToolStripMenuItem,
            this.notHumanToolStripMenuItem});
            this.uselessButtonsToolStripMenuItem.Name = "uselessButtonsToolStripMenuItem";
            this.uselessButtonsToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.uselessButtonsToolStripMenuItem.Text = "Useless Buttons";
            // 
            // humanToolStripMenuItem
            // 
            this.humanToolStripMenuItem.Name = "humanToolStripMenuItem";
            this.humanToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.humanToolStripMenuItem.Text = "Human";
            // 
            // notHumanToolStripMenuItem
            // 
            this.notHumanToolStripMenuItem.Name = "notHumanToolStripMenuItem";
            this.notHumanToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.notHumanToolStripMenuItem.Text = "Not human";
            // 
            // lstHuman
            // 
            this.lstHuman.Font = new System.Drawing.Font("Star Jedi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHuman.FormattingEnabled = true;
            this.lstHuman.ItemHeight = 26;
            this.lstHuman.Items.AddRange(new object[] {
            "Human",
            "oTher"});
            this.lstHuman.Location = new System.Drawing.Point(445, 448);
            this.lstHuman.Name = "lstHuman";
            this.lstHuman.Size = new System.Drawing.Size(71, 56);
            this.lstHuman.TabIndex = 7;
            // 
            // radHuman
            // 
            this.radHuman.AutoSize = true;
            this.radHuman.Font = new System.Drawing.Font("Star Jedi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHuman.Location = new System.Drawing.Point(320, 474);
            this.radHuman.Name = "radHuman";
            this.radHuman.Size = new System.Drawing.Size(101, 30);
            this.radHuman.TabIndex = 8;
            this.radHuman.TabStop = true;
            this.radHuman.Text = "Human";
            this.radHuman.UseVisualStyleBackColor = true;
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Font = new System.Drawing.Font("Star Jedi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOther.Location = new System.Drawing.Point(221, 474);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(93, 30);
            this.radOther.TabIndex = 9;
            this.radOther.TabStop = true;
            this.radOther.Text = "oTher";
            this.radOther.UseVisualStyleBackColor = true;
            // 
            // lblUseless
            // 
            this.lblUseless.AutoSize = true;
            this.lblUseless.Font = new System.Drawing.Font("Star Jedi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUseless.Location = new System.Drawing.Point(86, 445);
            this.lblUseless.Name = "lblUseless";
            this.lblUseless.Size = new System.Drawing.Size(156, 26);
            this.lblUseless.TabIndex = 10;
            this.lblUseless.Text = "uSeless THiNgs:";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 638);
            this.Controls.Add(this.lblUseless);
            this.Controls.Add(this.radOther);
            this.Controls.Add(this.radHuman);
            this.Controls.Add(this.lstHuman);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAbout";
            this.Text = "Meeeeeee!!!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem uselessButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notHumanToolStripMenuItem;
        private System.Windows.Forms.ListBox lstHuman;
        private System.Windows.Forms.RadioButton radHuman;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.Label lblUseless;
    }
}