using System;

namespace WindowsFormsApp1
{
    partial class BKLND
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BKLND));
            this.Bakubtn = new System.Windows.Forms.RadioButton();
            this.Londonbtn = new System.Windows.Forms.RadioButton();
            this.circularClock = new CircularProgressBar.CircularProgressBar();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bakubtn
            // 
            this.Bakubtn.AutoSize = true;
            this.Bakubtn.BackColor = System.Drawing.Color.Transparent;
            this.Bakubtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bakubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bakubtn.ForeColor = System.Drawing.Color.Transparent;
            this.Bakubtn.Location = new System.Drawing.Point(35, 400);
            this.Bakubtn.Name = "Bakubtn";
            this.Bakubtn.Size = new System.Drawing.Size(50, 17);
            this.Bakubtn.TabIndex = 0;
            this.Bakubtn.Text = "Baku";
            this.Bakubtn.UseVisualStyleBackColor = false;
            this.Bakubtn.CheckedChanged += new System.EventHandler(this.Bakubtn_CheckedChanged);
            // 
            // Londonbtn
            // 
            this.Londonbtn.AutoSize = true;
            this.Londonbtn.BackColor = System.Drawing.Color.Transparent;
            this.Londonbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Londonbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Londonbtn.ForeColor = System.Drawing.Color.Transparent;
            this.Londonbtn.Location = new System.Drawing.Point(695, 400);
            this.Londonbtn.Name = "Londonbtn";
            this.Londonbtn.Size = new System.Drawing.Size(61, 17);
            this.Londonbtn.TabIndex = 1;
            this.Londonbtn.TabStop = true;
            this.Londonbtn.Text = "London";
            this.Londonbtn.UseVisualStyleBackColor = false;
            this.Londonbtn.CheckedChanged += new System.EventHandler(this.Londonbtn_CheckedChanged);
            // 
            // circularClock
            // 
            this.circularClock.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularClock.AnimationSpeed = 500;
            this.circularClock.BackColor = System.Drawing.Color.Transparent;
            this.circularClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularClock.ForeColor = System.Drawing.Color.Red;
            this.circularClock.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.circularClock.InnerMargin = 2;
            this.circularClock.InnerWidth = -1;
            this.circularClock.Location = new System.Drawing.Point(257, 228);
            this.circularClock.MarqueeAnimationSpeed = 2000;
            this.circularClock.Name = "circularClock";
            this.circularClock.OuterColor = System.Drawing.Color.SkyBlue;
            this.circularClock.OuterMargin = -25;
            this.circularClock.OuterWidth = 26;
            this.circularClock.ProgressColor = System.Drawing.Color.SteelBlue;
            this.circularClock.ProgressWidth = 18;
            this.circularClock.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularClock.Size = new System.Drawing.Size(269, 210);
            this.circularClock.StartAngle = 270;
            this.circularClock.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularClock.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.circularClock.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularClock.SubscriptText = "00";
            this.circularClock.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.circularClock.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularClock.SuperscriptText = "";
            this.circularClock.TabIndex = 2;
            this.circularClock.Text = "00:00:00";
            this.circularClock.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularClock.Value = 68;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Back.Location = new System.Drawing.Point(1, 1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(40, 24);
            this.Back.TabIndex = 3;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // BKLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.circularClock);
            this.Controls.Add(this.Londonbtn);
            this.Controls.Add(this.Bakubtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BKLND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baku - London";
            this.Load += new System.EventHandler(this.BKLND_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Bakubtn;
        private System.Windows.Forms.RadioButton Londonbtn;
        private CircularProgressBar.CircularProgressBar circularClock;
        private System.Windows.Forms.Button Back;
    }
}