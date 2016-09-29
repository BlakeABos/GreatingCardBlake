using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
    
namespace GreatingCardBlake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            greetingButton.Visible = false;
            playButton.Visible = false;
            aries.Visible = false;
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.White, 10);
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Pen drawPen3 = new Pen(Color.White, 5);
            Pen drawPen2 = new Pen(Color.White, 3);
            formGraphics.DrawEllipse(drawPen, 26, 68, 10, 10);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen, 151, 101, 10, 10);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen, 237, 159, 10, 10);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen, 244, 191, 10, 10);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 270, 241, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 2, 15, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 160, 35, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 90, 15, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 76, 69, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 69, 139, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 26, 149, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 150, 159, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 76, 130, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 120, 65, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 290, 15, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 262, 31, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 205, 50, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 200, 25, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 241, 130, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 138, 11, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 20, 18, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3,70, 100, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawEllipse(drawPen3, 160, 001, 5, 5);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen2, 151, 101, 244, 165);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen2, 26, 72, 151, 105);
            Thread.Sleep(500);
            formGraphics.DrawLine(drawPen2, 248, 189, 240, 162);
            Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("Arial", 8, FontStyle.Regular);
            fg.DrawString("Aries is one of the constellations of the ", drawFont, drawBrush, 5, 170);
            fg.DrawString(" zodiac. It is located in the northern celestial .", drawFont, drawBrush, 5, 190);
            fg.DrawString("hemisphere between Pisces to the west and Taurus", drawFont, drawBrush, 5, 210);
            fg.DrawString(" to the east. The name Aries is Latin for ram, and its ", drawFont, drawBrush, 5, 230);
            fg.DrawString(" symbol is (Unicode ♈), representing a ram's horns.", drawFont, drawBrush, 5, 250);
            SoundPlayer player = new SoundPlayer(Properties.Resources.Star);
            player.Play();
            //


        }
    }
}
