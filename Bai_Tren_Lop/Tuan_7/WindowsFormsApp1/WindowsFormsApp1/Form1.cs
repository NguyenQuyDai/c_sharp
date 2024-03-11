using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(Graphics g)
        {
            // Định nghĩa màu sắc và vị trí cho các vòng
            var colors = new[] { Color.Blue, Color.Black, Color.Red, Color.Yellow, Color.Green };
            var positions = new[] { new Point(50, 50), new Point(150, 50), new Point(250, 50), new Point(100, 100), new Point(200, 100) };

            // Tạo một bút với độ rộng phù hợp
            var penWidth = 10.0f;

            // Vẽ từng vòng
            for (int i = 0; i < colors.Length; i++)
            {
                using (var pen = new Pen(colors[i], penWidth))
                {
                    g.DrawEllipse(pen, positions[i].X, positions[i].Y, 100, 100);
                }
            }
        }
    }
}
