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
using System.Collections;


namespace Anime_Yu_Gi_Oh_Card_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String IconSeletion="Wind";
        String CardSeletion;
        String LevelSelection;
        private void button1_Click(object sender, EventArgs e)
        {
            String ATK = ATKt.Text;
            String DEF = DEFt.Text;
            Image mainImage = Bitmap.FromFile("Resources/" + "Fusion" + ".jpg");
            Image Icon = Bitmap.FromFile("Resources/" + IconSeletion + ".png");
            Image Level = Bitmap.FromFile("Resources/" + LevelSelection + ".png");

            Rectangle rect1 = new Rectangle(49, 505, 261, 506);
            Rectangle rect2 = new Rectangle(49, 505, 261, 506);

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
               // if (string.IsNullOrEmpty(ATK)) { ATK = "800"; };
                SizeF si = g.MeasureString(ATK, this.Font);
                float fontScale = 15;
                using (Font font = new Font("EuroRoman", this.Font.SizeInPoints / fontScale, GraphicsUnit.Point))
                {
                    g.DrawString(ATK, font, Brushes.Black, rect1, stringFormat);
                }

                //save new image
                mainImage.Save("classy.png");
            }
           
           //pictureBox1.Image = Main;

                       
        }

        private void Element_SelectedIndexChanged(object sender, EventArgs e)
        {
            IconSeletion = Element.SelectedItem.ToString();
      
        }


        private void Fusion_Click(object sender, EventArgs e)
        {
             CardSeletion = "Fusion";
        }

        private void Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            LevelSelection = Level.SelectedItem.ToString();
        }

       





     

    }
}
