using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Bai3_NguyenQuyDai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button dish = (Button)sender;

            // Lấy tên món ăn hoặc đồ uống từ nút button được nhấn
            string itemName = dish.Text;

            // Tạo một ListViewItem mới chứa dữ liệu của món ăn hoặc đồ uống
            ListViewItem item = new ListViewItem(itemName);
            item.SubItems.Add("1");
            listView1.Items.Add(item);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
            }
            else
            {
                // Hiển thị một thông báo cho người dùng nếu không có mục nào được chọn
                MessageBox.Show("Vui lòng chọn một mục để xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có món nào được đặt hay không
            if (listView1.Items.Count > 0)
            {
                int ban = int.Parse(comboBox.Text);

                // Khởi tạo một chuỗi để chứa thông tin về tất cả các món ăn
                StringBuilder sb = new StringBuilder();

                // Lặp qua danh sách các mục trong ListView
                foreach (ListViewItem item in listView1.Items)
                {
                    // Trích xuất tên món ăn từ mỗi mục và thêm vào chuỗi
                    string itemName = item.Text;
                    sb.AppendLine(itemName);
                }

                // Hiển thị thông tin về tất cả các món ăn
                MessageBox.Show($"Bàn số {ban} đã đặt các món:\n{sb.ToString()}", "Danh sách món đã đặt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hiển thị thông báo nếu không có món nào được đặt
                MessageBox.Show("Chưa có món nào được đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
