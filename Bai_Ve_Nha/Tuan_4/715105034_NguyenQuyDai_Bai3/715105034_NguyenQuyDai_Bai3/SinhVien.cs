using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai3
{
    internal class SinhVien
    {
        public string maSV { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public double toan{get; set;}
        public double ly { get; set; }
        public double hoa { get; set; }
        public double diemTB { get; set; }
        public SinhVien() { }
        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, double toan, double ly, double hoa, double diemTB)
        {
            this.maSV = maSV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
            this.diemTB = diemTB;
        }
        public double tinhDiemTB()
        {
            return diemTB=(toan + hoa + ly) / 3;
        }
        public void nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào mã sinh viên:");
            maSV = Console.ReadLine();
            Console.Write("Nhập vào họ và tên:");
            hoTen = Console.ReadLine();
            Console.Write("Nhập vào ngày sinh:");
            ngaySinh = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write("Nhập vào điểm toán:");
            toan = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào điểm lý:");
            ly = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào điểm hóa:");
            hoa = double.Parse(Console.ReadLine());
            diemTB = tinhDiemTB();
        }
        public  void xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Mã sinh viên là:{maSV}");
            Console.WriteLine($"Họ tên sinh viên:{hoTen}");
            Console.WriteLine($"Ngày sinh sinh viên:{ngaySinh}");
            Console.WriteLine($"Điểm toán:{toan}");
            Console.WriteLine($"Điểm lý:{ly}");
            Console.WriteLine($"Điểm hóa:{hoa}");
            Console.WriteLine($"Điểm trung bình:{diemTB}");
        }
    }
}
