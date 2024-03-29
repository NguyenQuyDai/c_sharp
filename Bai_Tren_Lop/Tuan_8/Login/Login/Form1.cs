using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length == 0 || txtUser.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản và mật khẩu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if((txtPassword.Text.Length<6||txtPassword.Text.Length>31)|| (txtUser.Text.Length < 6 || txtUser.Text.Length > 31))
            {
                MessageBox.Show("Tài khoản và mật khẩu phải có độ dài từ 6-30 ký tự", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
