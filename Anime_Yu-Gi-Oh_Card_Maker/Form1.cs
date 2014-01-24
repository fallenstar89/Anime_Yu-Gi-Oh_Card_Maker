using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Drawing.Imaging;


namespace Anime_Yu_Gi_Oh_Card_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String IconSeletion = "Wind";
        String CardSeletion = "Fusion";
        String LevelSelection = "1";
        PrivateFontCollection pfc = new PrivateFontCollection();
        Image userimage;
        private void button1_Click(object sender, EventArgs e)
        {
            String ATK = ATKt.Text;
            String DEF = DEFt.Text;
            Image mainImage = Bitmap.FromFile("Resources/" + CardSeletion + ".jpg");
            Image Icon = Bitmap.FromFile("Resources/" + IconSeletion + ".png");
            Image Level = Bitmap.FromFile("Resources/" + LevelSelection + ".png");

            Rectangle rect1 = new Rectangle(49, 505, 261, 506);

            StringFormat stringFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };




            using (Graphics g = Graphics.FromImage(mainImage))
            {
                //draw other image on top of main Image

                // Create font and brush.
                Font drawFont = new Font("EuroRoman", 16,FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Black);

                // Create point f
                PointF ATK1 = new PointF(90.0F, 706.0F);
                PointF DEF1 = new PointF(350.0F, 706.0F);

                PointF ATK2 = new PointF(70.0F, 706.0F);
                PointF DEF2 = new PointF(330.0F, 706.0F);


                if (userimage != null) { userimage = ScaleImage(userimage, 150, 160); g.DrawImage(userimage, 13, 14); }

                if (CardSeletion.Equals("Effect") || CardSeletion.Equals("Fusion") || CardSeletion.Equals("Ritual") || CardSeletion.Equals("Synchro"))
                {
                    g.DrawImage(Icon, new Point(0, 0));
                    g.DrawImage(Level, new Point(0, 0));
                    if (ATK.Length == 3) { g.DrawString(ATK, drawFont, drawBrush, ATK1); } else { g.DrawString(ATK, drawFont, drawBrush, ATK2); }
                    if (DEF.Length == 3) { g.DrawString(DEF, drawFont, drawBrush, DEF1); } else { g.DrawString(DEF, drawFont, drawBrush, DEF2); }
                }


                //pictureBox1.Image = userimage;


                //save new image
                SaveFileDialog dialog = new SaveFileDialog();
                ImageFormat format = ImageFormat.Png;
                dialog.Filter = "PNG (*.png)|*.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    mainImage.Save(dialog.FileName, format);
                }




                //pictureBox1.Image = Main;


            }
        }
        


        private void Element_SelectedIndexChanged(object sender, EventArgs e)
        {
            IconSeletion = Element.SelectedItem.ToString();
        }


        private void Level_SelectedIndexChanged(object sender, EventArgs e)
        {
            LevelSelection = Level.SelectedItem.ToString();
        }

        private void Fusion_Click(object sender, EventArgs e)
        {
            CardSeletion = "Fusion";
            Bitmap bmp = Properties.Resources.Fusion__69x100_;
            pictureBox1.Image = bmp;
        }

        private void LegendaryDragon_Click(object sender, EventArgs e)
        {
            CardSeletion = "LegendaryDragon";
            Bitmap bmp = Properties.Resources.Legendary_Dragon__Custom_;
            pictureBox1.Image = bmp;
        }

        private void DuelistKingdomCard_Click(object sender, EventArgs e)
        {
            CardSeletion = "DuelistKingdomCard";
            Bitmap bmp = Properties.Resources.Duelist_Kingdom_Card__Custom_;
            pictureBox1.Image = bmp;
        }

        private void Effect_Click(object sender, EventArgs e)
        {
            CardSeletion = "Effect";
            Bitmap bmp = Properties.Resources.Effect__Custom_;
            pictureBox1.Image = bmp;
        }

        private void Trap_Click(object sender, EventArgs e)
        {
            CardSeletion = "Trap";
            Bitmap bmp = Properties.Resources.Trap__Custom_;
            pictureBox1.Image = bmp;
        }

        private void Magic_Click(object sender, EventArgs e)
        {
            CardSeletion = "Magic";
            Bitmap bmp = Properties.Resources.Magic__Custom_;
            pictureBox1.Image = bmp;
        }

        private void NormalMonster_Click(object sender, EventArgs e)
        {
            CardSeletion = "NormalMonster";
            Bitmap bmp = Properties.Resources.Normal_Monster__Custom_;
            pictureBox1.Image = bmp;
        }

        private void Ritual_Click(object sender, EventArgs e)
        {
            CardSeletion = "Ritual";
            Bitmap bmp = Properties.Resources.Ritual__Custom_;
            pictureBox1.Image = bmp;
        }

        private void Synchro_Click(object sender, EventArgs e)
        {
            CardSeletion = "Synchro";
            Bitmap bmp = Properties.Resources.Synchro__Custom_;
            pictureBox1.Image = bmp;
        }

        private void Token_Click(object sender, EventArgs e)
        {
            CardSeletion = "Token";
            Bitmap bmp = Properties.Resources.Token__Custom_;
            pictureBox1.Image = bmp;
        }



        private void ImportImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.jpg, *.gif, *.png, *.bmp)|*.jpg;*.gif;*.png;*.bmp|JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|GIF Files (*.gif)|*.gif";

                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    userimage = new Bitmap(dlg.FileName);
                }

            }
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var newImage = new Bitmap(maxWidth, maxHeight);
            Graphics.FromImage(newImage).DrawImage(image, 0, 0, maxWidth, maxHeight);
            return newImage;
        }
        private void LoadFont()
        {
            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("embedfont.Font.ttf");
            byte[] fontdata = new byte[fontStream.Length];
      fontStream.Read(fontdata,0,(int)fontStream.Length);
      fontStream.Close();
      unsafe
      {
        fixed(byte * pFontData = fontdata)
        {
          pfc.AddMemoryFont((System.IntPtr)pFontData,fontdata.Length);
        }
      }
        }
    }
}
        
     