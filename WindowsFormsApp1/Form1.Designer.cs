namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.welcome = new System.Windows.Forms.Label();
            this.BakuLondon = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.HoverGame = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.Red;
            this.welcome.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.welcome.Location = new System.Drawing.Point(-1, 0);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(801, 119);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to my project dear user";
            this.welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcome.Click += new System.EventHandler(this.welcome_Click);
            // 
            // BakuLondon
            // 
            this.BakuLondon.AutoSize = true;
            this.BakuLondon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BakuLondon.Location = new System.Drawing.Point(109, 379);
            this.BakuLondon.Name = "BakuLondon";
            this.BakuLondon.Size = new System.Drawing.Size(89, 17);
            this.BakuLondon.TabIndex = 1;
            this.BakuLondon.Text = "Baku-London";
            this.BakuLondon.UseVisualStyleBackColor = true;
            this.BakuLondon.CheckedChanged += new System.EventHandler(this.BakuLondon_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // HoverGame
            // 
            this.HoverGame.AutoSize = true;
            this.HoverGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HoverGame.Location = new System.Drawing.Point(639, 379);
            this.HoverGame.Name = "HoverGame";
            this.HoverGame.Size = new System.Drawing.Size(82, 17);
            this.HoverGame.TabIndex = 2;
            this.HoverGame.Text = "HoverGame";
            this.HoverGame.UseVisualStyleBackColor = true;
            this.HoverGame.CheckedChanged += new System.EventHandler(this.HoverGame_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 171);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(489, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 171);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.HoverGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BakuLondon);
            this.Controls.Add(this.welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aliyev\'s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.RadioButton BakuLondon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton HoverGame;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

