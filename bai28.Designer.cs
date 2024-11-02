using System.Drawing;
using System.Windows.Forms;

namespace phamquangminh_2122110339
{
    partial class bai28
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.tmStopwatch = new System.Windows.Forms.Timer(this.components);
            this.lbDiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDisplay.Location = new System.Drawing.Point(8, 25);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(62, 25);
            this.lblDisplay.TabIndex = 2;
            this.lblDisplay.Text = "00:00";
            // 
            // tmStopwatch
            // 
            this.tmStopwatch.Interval = 1000;
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.BackColor = System.Drawing.Color.Transparent;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDiem.Location = new System.Drawing.Point(9, 5);
            this.lbDiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(63, 20);
            this.lbDiem.TabIndex = 3;
            this.lbDiem.Text = "Điểm: 0";
            // 
            // bai28
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lblDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "bai28";
            this.Text = "bai28";
            this.Load += new System.EventHandler(this.bai28_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bai28_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Timer tmStopwatch;
        private System.Windows.Forms.Label lbDiem;
    }
}