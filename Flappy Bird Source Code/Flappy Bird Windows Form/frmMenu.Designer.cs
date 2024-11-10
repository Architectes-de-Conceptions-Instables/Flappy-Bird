
namespace Flappy_Bird_Windows_Form
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnAbout = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.rbutton;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.ContextMenuStrip = this.contextMenuStrip1;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Star Jedi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(49, 357);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(127, 52);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "ABout";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlay,
            this.mnuAbout,
            this.mnuCancel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 100);
            // 
            // mnuPlay
            // 
            this.mnuPlay.Name = "mnuPlay";
            this.mnuPlay.Size = new System.Drawing.Size(135, 32);
            this.mnuPlay.Text = "Play";
            this.mnuPlay.Click += new System.EventHandler(this.mnuPlay_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(135, 32);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuCancel
            // 
            this.mnuCancel.Name = "mnuCancel";
            this.mnuCancel.Size = new System.Drawing.Size(135, 32);
            this.mnuCancel.Text = "Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.rbutton;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.ContextMenuStrip = this.contextMenuStrip1;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Star Jedi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(310, 366);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 52);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "cAncel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Flappy_Bird_Windows_Form.Properties.Resources.bbutton;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.ContextMenuStrip = this.contextMenuStrip1;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Star Jedi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(194, 249);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(210, 81);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "pLay";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // picBack
            // 
            this.picBack.ContextMenuStrip = this.contextMenuStrip1;
            this.picBack.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.fd32d66da022907ca55e1a6046dd62e6;
            this.picBack.Location = new System.Drawing.Point(0, 1);
            this.picBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(500, 301);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBack.TabIndex = 5;
            this.picBack.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(710, 452);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuPlay;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuCancel;
    }
}