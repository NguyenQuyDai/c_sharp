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
        private TextBox txtInput;
        private Button[] keyboardButtons;
        public Form1()
        {
            InitializeComponent();
            InitializeKeyboard();

        }
        private void InitializeKeyboard()
        {
            // Khởi tạo TextBox
            txtInput = new TextBox();
            txtInput.Dock = DockStyle.Top;
            txtInput.ReadOnly = true;
            txtInput.Multiline = true;
            txtInput.Font = new Font("Arial", 12);
            txtInput.ForeColor = Color.Black;
            txtInput.BackColor = Color.White;
            txtInput.Height = 50;
            this.Controls.Add(txtInput);
            keyboardButtons = new Button[10]; // Chỉ định các nút cho các số từ 0 đến 9
            for (int i = 0; i < keyboardButtons.Length; i++)
            {
                keyboardButtons[i] = new Button();
                keyboardButtons[i].Text = i.ToString();
                keyboardButtons[i].Width = 40;
                keyboardButtons[i].Height = 40;
                keyboardButtons[i].Font = new Font("Arial", 10);
                keyboardButtons[i].ForeColor = Color.Black;
                keyboardButtons[i].BackColor = Color.LightGray;
                keyboardButtons[i].Enabled = false; // Không cho phép kích hoạt sự kiện click
                keyboardButtons[i].KeyDown += KeyboardButton_KeyDown;
                keyboardButtons[i].KeyUp += KeyboardButton_KeyUp;
            }
            // Sắp xếp các nút cho bàn phím ảo
            FlowLayoutPanel keyboardPanel = new FlowLayoutPanel();
            keyboardPanel.Dock = DockStyle.Fill;
            keyboardPanel.FlowDirection = FlowDirection.LeftToRight;
            keyboardPanel.WrapContents = false;
            keyboardPanel.BackColor = Color.DarkGray;
            foreach (Button btn in keyboardButtons)
            {
                keyboardPanel.Controls.Add(btn);
            }
            this.Controls.Add(keyboardPanel);
        }
        private void KeyboardButton_KeyDown(object sender, KeyEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Yellow; // Highlight button khi nhấn xuống
                txtInput.AppendText(btn.Text); // Hiển thị ký tự đã gõ trong TextBox
            }
        }

        private void KeyboardButton_KeyUp(object sender, KeyEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.LightGray; // Trở lại trạng thái bình thường khi thả phím ra
            }
        }

    }
}
