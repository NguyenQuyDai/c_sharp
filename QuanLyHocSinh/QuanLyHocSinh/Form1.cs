using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace QuanLyHocSinh
{
    public partial class Form1 : Form
    {
        private string connect;
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter dataAdapter;
        public Form1()
        {
            InitializeComponent();

        }


        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            // Mở kết nối đến cơ sở dữ liệu
            sqlConnection.Open();

            // Tạo một chuỗi truy vấn SQL để lấy tất cả dữ liệu từ bảng Student
            // nơi mã học sinh (maHS) chứa chuỗi ký tự được nhập vào từ textbox txtMaSo
            string query = "select * from Student where maHS like @maHS;";

            // Tạo một SqlCommand mới với chuỗi truy vấn và kết nối đã khai báo
            sqlCommand = new SqlCommand(query, sqlConnection);

            // Thêm một tham số vào câu truy vấn SQL
            // Tham số này sẽ được thay thế bằng giá trị từ textbox txtMaSo
            sqlCommand.Parameters.AddWithValue("maHS", "%" + txtMaSo.Text + "%");

            // Tạo một SqlDataAdapter mới với SqlCommand đã khai báo
            dataAdapter = new SqlDataAdapter(sqlCommand);

            // Tạo một DataTable mới để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();

            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            dataAdapter.Fill(dataTable);

            // Đặt nguồn dữ liệu cho DataGridView là DataTable vừa tạo
            dtgDSHS.DataSource = dataTable;

            // Đóng kết nối đến cơ sở dữ liệu
            sqlConnection.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connect = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=db_student;Integrated Security=True;";
                sqlConnection = new SqlConnection(connect);

                txtHoTen.Focus();
                // Mở kết nối đến cơ sở dữ liệu
                sqlConnection.Open();

                // Tạo một SqlDataAdapter mới để truy vấn dữ liệu từ bảng Student
                dataAdapter = new SqlDataAdapter("select * from Student;", connect);

                // Tạo một DataTable mới để lưu trữ dữ liệu
                DataTable dataTable = new DataTable();

                // Đổ dữ liệu từ SqlDataAdapter vào DataTable
                dataAdapter.Fill(dataTable);

                // Đặt nguồn dữ liệu cho DataGridView là DataTable vừa tạo
                dtgDSHS.DataSource = dataTable;

                // Đóng kết nối đến cơ sở dữ liệu
                sqlConnection.Close();


                Total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHoTen.Focus();
            // Mở kết nối đến cơ sở dữ liệu
            sqlConnection.Open();

            // Tạo một SqlDataAdapter mới để truy vấn dữ liệu từ bảng Student
            dataAdapter = new SqlDataAdapter("select * from Student;", connect);

            // Tạo một DataTable mới để lưu trữ dữ liệu
            DataTable dataTable = new DataTable();

            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            dataAdapter.Fill(dataTable);

            // Đặt nguồn dữ liệu cho DataGridView là DataTable vừa tạo
            dtgDSHS.DataSource = dataTable;

            // Đóng kết nối đến cơ sở dữ liệu
            sqlConnection.Close();


            Total();
        }


        private void Total()
        {
            int count = 0;
            if (dtgDSHS.Rows.Count <= 0)
            {
                txtTongHS.Text = "0";
            }
            else
            {
                count = int.Parse(dtgDSHS.Rows.Count.ToString());
                txtTongHS.Text = count.ToString();
            }

        }

        private void dtgDSHS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng hay không
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dtgDSHS.Rows[e.RowIndex];

                // Gán giá trị từ các ô trong dòng vào các TextBox tương ứng

                // Gán giá trị của cột "Ma" vào TextBox txtMa
                txtMaHS.Text = row.Cells["maHS"].Value.ToString();

                // Gán giá trị của cột "HoTen" vào TextBox txtHoTen
                txtHoTen.Text = row.Cells["hoTen"].Value.ToString();

                // Gán giá trị của cột "Lop" vào TextBox txtLop
                txtLop.Text = row.Cells["lop"].Value.ToString();

                // Gán giá trị của cột "NgaySinh" vào TextBox txtNgaySinh
                dteNgaySinh.Text = row.Cells["ngaySinh"].Value.ToString();

                // Gán giá trị của cột "GioiTinh" vào TextBox txtGioiTinh
                txtGioiTinh.Text = row.Cells["gioiTinh"].Value.ToString();

                // Gán giá trị của cột "DiaChi" vào TextBox txtDiaChi
                txtDiaChi.Text = row.Cells["diaChi"].Value.ToString();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Length > 0 && txtLop.Text.Length > 0 && txtDiaChi.Text.Length > 0 && dteNgaySinh.Text.Length > 0 && txtGioiTinh.Text.Length > 0)
            {
                txtMaHS.Text = "";
                sqlConnection.Open();
                string query = "insert into Student(hoTen,lop,ngaySinh,gioiTinh,diaChi) values(@hoTen,@lop,@ngaySinh,@gioiTinh,@diaChi);";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@hoTen", txtHoTen.Text);
                sqlCommand.Parameters.AddWithValue("@lop", txtLop.Text);
                sqlCommand.Parameters.AddWithValue("@ngaySinh", dteNgaySinh.Text);
                sqlCommand.Parameters.AddWithValue("@gioiTinh", txtGioiTinh.Text);
                sqlCommand.Parameters.AddWithValue("@diaChi", txtDiaChi.Text);
                sqlCommand.ExecuteNonQuery();

                // Làm mới lại dữ liệu trong DataGridView
                dataAdapter = new SqlDataAdapter("select * from Student", sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dtgDSHS.DataSource = dataTable;
                MessageBox.Show("Thêm mới học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin để thông mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Length > 0 && txtLop.Text.Length > 0 && txtDiaChi.Text.Length > 0 && dteNgaySinh.Text.Length > 0 && txtGioiTinh.Text.Length > 0)
            {
                int maHS = Convert.ToInt32(txtMaHS.Text);
                sqlConnection.Open();
                string query = "update Student set hoTen = @hoTen , lop = @lop, ngaySinh = @ngaySinh, gioiTinh = @gioiTinh, diaChi = @diaChi WHERE maHS = @maHS;";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@maHS", maHS);
                sqlCommand.Parameters.AddWithValue("@hoTen", txtHoTen.Text);
                sqlCommand.Parameters.AddWithValue("@lop", txtLop.Text);
                sqlCommand.Parameters.AddWithValue("@ngaySinh", dteNgaySinh.Text);
                sqlCommand.Parameters.AddWithValue("@gioiTinh", txtGioiTinh.Text);
                sqlCommand.Parameters.AddWithValue("@diaChi", txtDiaChi.Text);
                sqlCommand.ExecuteNonQuery();
                // Làm mới lại dữ liệu trong DataGridView
                dataAdapter = new SqlDataAdapter("select * from Student", sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dtgDSHS.DataSource = dataTable;

                sqlConnection.Close();
                MessageBox.Show("Sửa thông tin học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học sinh để sửa thông mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Length > 0 && txtLop.Text.Length > 0 && txtDiaChi.Text.Length > 0 && dteNgaySinh.Text.Length > 0 && txtGioiTinh.Text.Length > 0)
            {
                int maHS = Convert.ToInt32(txtMaHS.Text);
                sqlConnection.Open();
                string query = "delete Student where maHS=@maHS";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@maHS", maHS);
                sqlCommand.ExecuteNonQuery();

                dataAdapter = new SqlDataAdapter("select * from Student", sqlConnection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dtgDSHS.DataSource = dataTable;
                sqlConnection.Close();
                MessageBox.Show("Xóa học sinh thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn học sinh muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xls)|*.xls";
            saveFileDialog.Title = "Xuất tệp đến excel";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dtgDSHS, saveFileDialog.FileName);
            }
        }
        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Đổ dữ liệu từ DataGridView vào Excel
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j + 1].Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }

                // Lưu Excel
                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);
            }

            MessageBox.Show("Đã lưu thành công!");
        }
    }
}
