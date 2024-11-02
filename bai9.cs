using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phamquangminh_2122110339
{
    public partial class bai9 : Form
    {
        
        public bai9()
        {
            InitializeComponent();
            this.btThoat.Anchor = ((AnchorStyles)(AnchorStyles.Bottom | AnchorStyles.Right));
            this.tbKetQua.Anchor=((AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom));
            this.StartPosition=FormStartPosition.CenterScreen;
            this.Text = "Caculator";

        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int x =int.Parse(tbSox.Text);
            int y=int.Parse(tbSoy.Text);
            int kq = x + y;
            tbKetQua.Text=tbKetQua.Text+x.ToString()+"+"+y.ToString()+"="+kq.ToString()+ "\r\n";

        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbSox.Text);
            int y = int.Parse(tbSoy.Text);
            int kq = x * y;
            tbKetQua.Text = tbKetQua.Text + x.ToString() + "*" + y.ToString() + "=" + kq.ToString() + "\r\n";

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Caculator.txt", true);
            sw.WriteLine(tbKetQua.Text);
            sw.Close();

        }
    }
}
