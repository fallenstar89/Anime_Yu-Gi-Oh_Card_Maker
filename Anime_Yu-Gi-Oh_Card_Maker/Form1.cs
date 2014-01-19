using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Anime_Yu_Gi_Oh_Card_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "-p");
            Image mainImage = Bitmap.FromFile("Resources/Fusion.jpg");
            Image Icon = Bitmap.FromFile("Resources/Dark.png");
            Image Level = Bitmap.FromFile("Resources/1.png");

            Rectangle rect1 = new Rectangle(49, 505, 261, 506);
            Rectangle rect2 = new Rectangle(49, 505, 261, 506);

            string ATK = "210";
            string DEF = "300";

            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };


            
            
            using (Graphics g = Graphics.FromImage(mainImage))
            {
                //draw other image on top of main Image
                g.DrawImage(Icon, new Point(0, 0));
                g.DrawImage(Level, new Point(0, 0));

                SizeF s = g.MeasureString(ATK, this.Font);
                float fontScale = Math.Max(s.Width / rect1.Width, s.Height / rect1.Height);
                using (Font font = new Font("EuroRoman", this.Font.SizeInPoints / fontScale, GraphicsUnit.Point))
                {
                    g.DrawString(ATK, font, Brushes.Black, rect1, stringFormat);
                }

                //save new image
                mainImage.Save("classy.png");
            }
           
           //pictureBox1.Image = Main;

                       
        }


    }
}
