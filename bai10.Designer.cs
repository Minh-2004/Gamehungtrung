namespace phamquangminh_2122110339
{
    partial class bai10
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
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btfloat = new System.Windows.Forms.Button();
            this.bEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(12, 25);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(391, 70);
            this.tbDisplay.TabIndex = 0;
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt0.Location = new System.Drawing.Point(12, 110);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(75, 55);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(112, 110);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 55);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(223, 110);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 55);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(328, 110);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 55);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.UseWaitCursor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(12, 191);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(75, 55);
            this.btPlus.TabIndex = 5;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMul
            // 
            this.btMul.Location = new System.Drawing.Point(112, 191);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(75, 55);
            this.btMul.TabIndex = 6;
            this.btMul.Text = "*";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.btMul_Click);
            // 
            // btfloat
            // 
            this.btfloat.Location = new System.Drawing.Point(223, 191);
            this.btfloat.Name = "btfloat";
            this.btfloat.Size = new System.Drawing.Size(75, 55);
            this.btfloat.TabIndex = 7;
            this.btfloat.Text = ".";
            this.btfloat.UseVisualStyleBackColor = true;
            this.btfloat.Click += new System.EventHandler(this.btfloat_Click);
            // 
            // bEquals
            // 
            this.bEquals.Location = new System.Drawing.Point(328, 191);
            this.bEquals.Name = "bEquals";
            this.bEquals.Size = new System.Drawing.Size(75, 55);
            this.bEquals.TabIndex = 8;
            this.bEquals.Text = "=";
            this.bEquals.UseVisualStyleBackColor = true;
            this.bEquals.Click += new System.EventHandler(this.bEquals_Click);
            // 
            // bai10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.bEquals);
            this.Controls.Add(this.btfloat);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.tbDisplay);
            this.Name = "bai10";
            this.Text = "bai10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btfloat;
        private System.Windows.Forms.Button bEquals;
    }
}