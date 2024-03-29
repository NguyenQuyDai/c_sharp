using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuyDai_Bai5
{
    public partial class Form1 : Form
    {
        private Color color,hightColor;
        private Font font;
        public Form1()
        {
            InitializeComponent();
         
        }

      
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void hightlightColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                hightColor = colorDialog.Color;
            }
        }

        private void textFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if(fontDialog.ShowDialog()== DialogResult.OK)
            {
                font = fontDialog.Font;
                textBox1.Font = font;
            }
        }

        private void button77_KeyDown(object sender, KeyEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.BackColor = hightColor;
                string keyPressed = button.Text;
                textBox1.Text += keyPressed;
            }
        }

        private void button77_KeyUp(object sender, KeyEventArgs e)
        {
            Button keyButton = sender as Button;
            if (keyButton != null)
            {
                keyButton.BackColor = Color.White;
            }
        }

        private void colorFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                textBox1.ForeColor = color;
            }
        }
    }
}
