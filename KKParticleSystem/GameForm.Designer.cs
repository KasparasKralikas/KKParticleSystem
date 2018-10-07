using System;

namespace KKParticleSystem
{
    partial class GameForm
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
            this.deltaLabel = new System.Windows.Forms.Label();
            this.particlesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deltaLabel
            // 
            this.deltaLabel.AutoSize = true;
            this.deltaLabel.BackColor = System.Drawing.Color.Black;
            this.deltaLabel.ForeColor = System.Drawing.Color.White;
            this.deltaLabel.Location = new System.Drawing.Point(28, 9);
            this.deltaLabel.Name = "deltaLabel";
            this.deltaLabel.Size = new System.Drawing.Size(18, 20);
            this.deltaLabel.TabIndex = 0;
            this.deltaLabel.Text = "0";
            this.deltaLabel.Click += new System.EventHandler(this.deltaLabel_Click);
            // 
            // particlesLabel
            // 
            this.particlesLabel.AutoSize = true;
            this.particlesLabel.BackColor = System.Drawing.Color.Black;
            this.particlesLabel.ForeColor = System.Drawing.Color.White;
            this.particlesLabel.Location = new System.Drawing.Point(28, 38);
            this.particlesLabel.Name = "particlesLabel";
            this.particlesLabel.Size = new System.Drawing.Size(18, 20);
            this.particlesLabel.TabIndex = 1;
            this.particlesLabel.Text = "0";
            this.particlesLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 584);
            this.Controls.Add(this.particlesLabel);
            this.Controls.Add(this.deltaLabel);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deltaLabel;
        private System.Windows.Forms.Label particlesLabel;
    }
}

