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
            this.SuspendLayout();
            // 
            // deltaLabel
            // 
            this.deltaLabel.AutoSize = true;
            this.deltaLabel.Location = new System.Drawing.Point(776, 9);
            this.deltaLabel.Name = "deltaLabel";
            this.deltaLabel.Size = new System.Drawing.Size(18, 20);
            this.deltaLabel.TabIndex = 0;
            this.deltaLabel.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 584);
            this.Controls.Add(this.deltaLabel);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deltaLabel;
    }
}

