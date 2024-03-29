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
        private Color color;
        private int X, Y;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(VeTheoToaDo);
        }

        private void VeTheoToaDo(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            SolidBrush solid = new SolidBrush(color);
            graphics.FillRectangle(solid, X, Y, 100, 200);
        }

        private void chonMau(object sender, MouseEventArgs e)
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
