namespace phamquangminh_2122110339
{
    partial class bai08
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
            this.so_x = new System.Windows.Forms.Label();
            this.so_y = new System.Windows.Forms.Label();
            this.ketqua = new System.Windows.Forms.Label();
            this.tbSoX = new System.Windows.Forms.TextBox();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.cong = new System.Windows.Forms.Button();
            this.nhan = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // so_x
            // 
            this.so_x.AutoSize = true;
            this.so_x.Location = new System.Drawing.Point(60, 42);
            this.so_x.Name = "so_x";
            this.so_x.Size = new System.Drawing.Size(28, 13);
            this.so_x.TabIndex = 0;
            this.so_x.Text = "Số x";
            // 
            // so_y
            // 
            this.so_y.AutoSize = true;
            this.so_y.Location = new System.Drawing.Point(60, 76);
            this.so_y.Name = "so_y";
            this.so_y.Size = new System.Drawing.Size(28, 13);
            this.so_y.TabIndex = 1;
            this.so_y.Text = "Số y";
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Location = new System.Drawing.Point(60, 112);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(46, 13);
            this.ketqua.TabIndex = 2;
            this.ketqua.Text = "Kết Quả";
            // 
            // tbSoX
            // 
            this.tbSoX.Location = new System.Drawing.Point(118, 39);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(100, 20);
            this.tbSoX.TabIndex = 3;
            // 
            // tbSoY
            // 
            this.tbSoY.Location = new System.Drawing.Point(118, 73);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(100, 20);
            this.tbSoY.TabIndex = 4;
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(118, 109);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.Size = new System.Drawing.Size(100, 20);
            this.tbKetQua.TabIndex = 5;
            // 
            // cong
            // 
            this.cong.Location = new System.Drawing.Point(118, 171);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(75, 23);
            this.cong.TabIndex = 6;
            this.cong.Text = "Cộng";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // nhan
            // 
            this.nhan.Location = new System.Drawing.Point(228, 171);
            this.nhan.Name = "nhan";
            this.nhan.Size = new System.Drawing.Size(75, 23);
            this.nhan.TabIndex = 7;
            this.nhan.Text = "Nhân";
            this.nhan.UseVisualStyleBackColor = true;
            this.nhan.Click += new System.EventHandler(this.nhan_Click);
            // 
            // exits
            // 
            this.exits.Location = new System.Drawing.Point(354, 171);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(75, 23);
            this.exits.TabIndex = 8;
            this.exits.Text = "Thoát";
            this.exits.UseVisualStyleBackColor = true;
            this.exits.Click += new System.EventHandler(this.exits_Click);
            // 
            // bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.nhan);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.so_y);
            this.Controls.Add(this.so_x);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bai08";
            this.Text = "bai08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label so_x;
        private System.Windows.Forms.Label so_y;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.Button nhan;
        private System.Windows.Forms.Button exits;
    }
}