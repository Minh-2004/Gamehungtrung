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
    public partial class bai25 : Form
    {
        PictureBox pbEgg =new PictureBox();
        PictureBox pbChicken=new PictureBox();
        Timer tmGame = new Timer();
        Timer tmChicken = new Timer();

        int xBall=0;
        int yBall=0;
        int xDeltal = 2;
        int yDeltal = 2;
        int xChicken = 4;
        int yChicken = 3;
        int xDeltaChicken = 3;
        int yDeltaChicken = 3;
        public bai25()
        {
            InitializeComponent();
        }

        private void bai25_Load(object sender, EventArgs e)
        {
            tmGame.Interval = 10;
            tmGame.Tick += TmGame_Tick;
            tmGame.Start();
            pbEgg.SizeMode =PictureBoxSizeMode.StretchImage;
            pbEgg.Location = new Point(xBall, yBall);
            pbEgg.Size = new Size(100, 100);
            this.Controls.Add(pbEgg);
            pbEgg.ImageLocation = @"D:\trung.png";

            tmChicken.Interval = 20;
            tmChicken.Tick += TmChiken_Tick;
            tmChicken.Start();
            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Location = new Point(xChicken, yChicken);
            pbChicken.Size = new Size(100, 100);
            this.Controls.Add(pbChicken);
            pbChicken.ImageLocation = @"D:\chicken.png";

        }

        private void TmGame_Tick(object sender, EventArgs e)
        {
            xBall += xDeltal;
            yBall += yDeltal;
            if (xBall > this.ClientSize.Width - pbEgg.Width || xBall <= 0)
                xDeltal=-xDeltal;
            if(yBall > this.ClientSize.Height - pbEgg.Height || yBall <= 0)
                yDeltal=-yDeltal;
            pbEgg.Location=new Point(xBall, yBall);
            
        }
        private void TmChiken_Tick(object sender, EventArgs e)
        {
            xChicken += xDeltaChicken;
            yChicken += yDeltaChicken;
            if (xChicken > this.ClientSize.Width - pbChicken.Width || xChicken <= 0)
                xDeltaChicken = -xDeltaChicken;
            if (yChicken > this.ClientSize.Height - pbChicken.Height || yChicken <= 0)
                yDeltaChicken = -yDeltaChicken;
            pbChicken.Location = new Point(xChicken, yChicken);

        }
    }
}
