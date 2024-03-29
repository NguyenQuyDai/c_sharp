using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuyDai_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbtnB1_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = false;
        }

        private void rdbtnB2_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbtnB1.Checked)
            {
                
                if (txtA.Text.Length > 0 && txtB.Text.Length > 0)
                {
                    if (txtA.Text == "0")
                    {
                        if (txtB.Text != "0")
                        {
                            txtKetQua.Text = "Phương trình vô nghiệm";
                        }
                        else
                        {
                            txtKetQua.Text = "Phương trình có vô số nghiệm";
                        }
                    }else
                    {
                         double A = double.Parse(txtA.Text);
                         double B = double.Parse(txtB.Text);
                         txtKetQua.Text = $"Phương trình có nghiệm:{-B/A}";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng không để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rdbtnB2.Checked)
            {
                
                if (txtA.Text.Length > 0 && txtB.Text.Length > 0 && txtC.Text.Length > 0)
                {
                    double A = double.Parse(txtA.Text);
                    double B = double.Parse(txtB.Text);
                    double C = double.Parse(txtC.Text);
                    double delta = B * B - 4 * A * C;
                    if (delta < 0)
                    {
                        txtKetQua.Text = "Phương trình vô nghiệm";
                    }else if (delta == 0)
                    {
                        txtKetQua.Text = $"Phương trình có nghiệm duy nhất:{-B / (2 * A)}";
                    }
                    else
                    {
                        txtKetQua.Text = $"Phương trình có 2 no: x1={(-B + Math.Sqrt(delta)) / (2 * A)},x2={(-B - Math.Sqrt(delta)) / (2 * A)}";
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng không để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
