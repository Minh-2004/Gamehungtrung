using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phamquangminh_2122110339
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bai06 frm6 = new bai06();
            frm6.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai07 frm7 = new Bai07();
            frm7.Show();
        }

        private void bai8_Click(object sender, EventArgs e)
        {
            bai08 frm8 = new bai08();
            frm8.Show();
        }

        private void bai9_Click(object sender, EventArgs e)
        {
            bai9 frm9 = new bai9(); 
            frm9.Show();
        }

        private void bai10_Click(object sender, EventArgs e)
        {
            bai10 frm10 = new bai10();
            frm10.Show();
        }

        private void bai11_Click(object sender, EventArgs e)
        {
            bai11 frm11 = new bai11();
            frm11.Show();
        }

        private void bai23_Click(object sender, EventArgs e)
        {
            bai23 frm23 = new bai23();  
            frm23.Show();
        }
    }
}
