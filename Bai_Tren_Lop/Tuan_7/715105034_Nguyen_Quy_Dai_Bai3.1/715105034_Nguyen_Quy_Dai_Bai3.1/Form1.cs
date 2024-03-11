using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _715105034_Nguyen_Quy_Dai_Bai3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1200, 700);
        }

        private void HCN(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            SolidBrush white = new SolidBrush(Color.White);
            SolidBrush red = new SolidBrush(Color.Red);
            SolidBrush blue = new SolidBrush(Color.Blue);
            SolidBrush black = new SolidBrush(Color.Black);
            SolidBrush gray = new SolidBrush(Color.Gray);
            // Vẽ đầu
            graphics.FillRectangle(red, 150, 50, 150, 75);
            graphics.FillRectangle(gray, 215, 125, 25, 25);
            // vẽ cổ
            graphics.FillRectangle(red, 125,150,200,200);
            // vẽ chân
            graphics.FillRectangle(gray, 150,350,25,150);
            graphics.FillRectangle(gray, 275,350,25,150);
            graphics.FillRectangle(blue, 100, 500, 100, 25);
            graphics.FillRectangle(blue, 250, 500, 100, 25);
            // vẽ cánh tay
            graphics.FillRectangle(gray, 50, 200, 75, 25);
            graphics.FillRectangle(gray, 50, 150, 25, 50);
            graphics.FillRectangle(gray, 325, 200, 75, 25);
            graphics.FillRectangle(gray, 375, 150, 25, 50);
            // vẽ miệng
            graphics.FillRectangle(black, 180, 100, 70, 10);
            // vẽ mắt
            graphics.FillRectangle(white, 170, 75, 85, 15);
            graphics.FillRectangle(black, 180, 78, 12, 12);
            graphics.FillRectangle(black, 235, 78, 12, 12);
        }
    }
}
