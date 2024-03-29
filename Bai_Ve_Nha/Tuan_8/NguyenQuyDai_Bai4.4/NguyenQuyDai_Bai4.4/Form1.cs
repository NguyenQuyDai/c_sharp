using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuyDai_Bai4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi chương trình", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lBoxDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBoxDV.SelectedIndex != null)
            {
                txtDVChon.AppendText(lBoxDV.SelectedItem.ToString()+ Environment.NewLine);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtNgay.Text.Length > 0 && txtThang.Text.Length > 0 && txtNam.Text.Length > 0)
            {
                string Ngay = txtNgay.Text;
                string Thang = txtThang.Text;
                string Nam = txtNam.Text;
                string hoTen = txtName.Text;
                string dichVu = txtDVChon.Text;
                txtKetQua.Text = "Họ tên" + hoTen+"Ngày sinh:"+Ngay+"/"+Thang + "/"+Nam;
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
