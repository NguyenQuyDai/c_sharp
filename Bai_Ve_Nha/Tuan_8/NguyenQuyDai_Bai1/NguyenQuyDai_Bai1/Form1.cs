using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuyDai_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            
        }


        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (txtName.Text !="")
            {
                long money = 0;
                if (ckbCaoVoi.Checked)
                {
                    money += 100000;
                }
                if (ckbTayTrang.Checked)
                {
                    money += 1200000;
                }
                if (ckbChupHinhRang.Checked)
                {
                    money += 150000;
                }
                if (ckbLayCao.Checked)
                {
                    money += 100000;
                }
                int soCaiRang = (int)caiRang.Value;
                money += (soCaiRang * 90000);
                lblMoney.Text = money.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));

            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
