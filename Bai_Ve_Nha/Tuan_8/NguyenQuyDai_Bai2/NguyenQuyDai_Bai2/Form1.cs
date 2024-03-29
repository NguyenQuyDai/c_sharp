using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuyDai_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <= 9; i++)
            {
                Button btnSo = new Button();
                btnSo.Text = i.ToString();
                btnSo.BackColor = Color.LightGray;
                btnSo.Size = new System.Drawing.Size(40, 40);
                btnSo.Click += BtnSo_Click;
                flowLayoutPanel1.Controls.Add(btnSo);
            }
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Size = new System.Drawing.Size(40, 40);
            btnOK.Click += BtnOK_Click;
            flowLayoutPanel1.Controls.Add(btnOK);

            Button btnC = new Button();
            btnC.Text = "C";
            btnC.Size = new System.Drawing.Size(40, 40);
            btnC.Click += BtnC_Click;
            flowLayoutPanel1.Controls.Add(btnC);
        }
        private void BtnSo_Click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                txtKetQua.Text += btn.Text;
            }
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            string code = txtKetQua.Text;
            string status = "";
            string Info = $"{DateTime.Now}:{status}";
            if (code == "1980" || code == "1982")
            {
                status = "Kỹ thuật";
                Info = $"{DateTime.Now}:{status}";
                
            }else if(code == "2008" || code == "2009" || code == "2009")
            {
                status = "Quản lý";
                Info = $"{DateTime.Now}:{status}";
                
            }
            else if (code == "9998" || code == "1006" || code == "1007" || code == "1008")
            {
                status = "Khoa học";
                Info = $"{DateTime.Now}:{status}";
                
            }
            txtKQ.AppendText(Info + "\n");
            txtKetQua.Clear();
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
        }
    }
}
