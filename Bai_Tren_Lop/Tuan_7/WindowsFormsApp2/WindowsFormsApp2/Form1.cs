using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Color color;
        private int X, Y;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(HCN);
        }

        private void HCN(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(color, 10);
            g.DrawRectangle(pen, X, Y, 100, 300);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
            if (e.Button == MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
            this.Invalidate();
        }
    }
}
