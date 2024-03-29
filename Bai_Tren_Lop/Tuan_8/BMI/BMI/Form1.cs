using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtWeight.Text.Length > 0 && txtHeight.Text.Length > 0)
            {
                double height = double.Parse(txtHeight.Text);
                double weight = double.Parse(txtWeight.Text);
                double BMI = weight / (height * height);
                lblCalBMI.Text = BMI.ToString();
                if (BMI < 18.5)
                {
                    txtNote.Text = "Gầy";
                }else if (BMI < 24.9)
                {
                    txtNote.Text = "Bình thường";
                }else if (BMI < 29.9)
                {
                    txtNote.Text = "Hơi béo";
                }else if (BMI < 34.9)
                {
                    txtNote.Text = "Béo phì";
                }
                else
                {
                    txtNote.Text = "Quá béo";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát khỏi form", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }
    }
}
