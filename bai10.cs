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
    public partial class bai10 : Form
    {
        decimal kq = 0;
        string opr = "";
        bool isResultDisplayed = false;
        public bai10()
        {
            InitializeComponent();
            bt0.Click -= new EventHandler(bt0_Click);
            bt0.Click += new EventHandler(bt0_Click);

            bt1.Click -= new EventHandler(bt1_Click);
            bt1.Click += new EventHandler(bt1_Click);

            bt2.Click -= new EventHandler(bt2_Click);
            bt2.Click += new EventHandler(bt2_Click);

            btfloat.Click -= new EventHandler(btfloat_Click);
            btfloat.Click += new EventHandler(btfloat_Click);
           
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            AppendToDisplay(bt0.Text);
        }
        private void AppendToDisplay(string text)
        {
            if (isResultDisplayed) // Nếu đang hiển thị kết quả, xóa nội dung hiện tại
            {
                tbDisplay.Clear();
                isResultDisplayed = false; // Đặt lại trạng thái
            }
            tbDisplay.Text += text; // Nối thêm giá trị
        }
        private void bEquals_Click(object sender, EventArgs e)
        {
            decimal seconValue=decimal.Parse(tbDisplay.Text);
            if (opr == "+")
                tbDisplay.Text=(kq+seconValue).ToString();
            if (opr == "*")
                tbDisplay.Text = (kq * seconValue).ToString();
            bool isResultDisplayed = true;
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            opr=btPlus.Text;
            kq= decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            AppendToDisplay(bt1.Text);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            AppendToDisplay(bt2.Text);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            AppendToDisplay(bt3.Text);
        }

        private void btfloat_Click(object sender, EventArgs e)
        {
            if (!tbDisplay.Text.Contains("."))
            {
                tbDisplay.Text += ".";
            }
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            opr = btMul.Text;
            kq = decimal.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }
    }
}
