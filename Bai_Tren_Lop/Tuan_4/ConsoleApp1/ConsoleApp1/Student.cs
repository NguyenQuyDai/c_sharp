using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string maSV { get; set; }
        public string hoTen { get; set; }
        public double diemToan { get; set; }
        public double diemAnh { get; set; }
        public double diemTB { get; set; }
        // Phương thức nhập dữ liệu từ bàn phím
        public void nhap()
        {
            Console.Write("Nhập mã sinh viên:");
            maSV = Console.ReadLine();
            Console.Write("Nhập họ tên sinh viên:");
            hoTen = Console.ReadLine();
            Console.Write("Nhập vào điểm Toán:");
            diemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhập vào điểm Anh:");
            diemAnh = double.Parse(Console.ReadLine());
        }
        // in ra màn hình
        public void xuat()
        {
            Console.WriteLine($"Mã sinh viên: {maSV}");
            Console.WriteLine($"Họ tên sinh viên: {hoTen}");
            Console.WriteLine($"Điểm Toán: {diemToan}");
            Console.WriteLine($"Điểm Anh: {diemAnh}");
            tinhDiemTB();
            Console.WriteLine($"Điểm trung bình: {diemTB}");
        }
        // TÍNH ĐIỂM TRUNG BÌNH
        public void tinhDiemTB()
        {
            diemTB = (diemToan * 2 + diemAnh) / 3;
        }
        public string xepLoai()
        {
            if (diemTB >= 8.5)
                return "Xuất sắc";
            else if (diemTB < 8.5 && diemTB >= 7.7)
                return "Giỏi";
            else if (diemTB >= 7 && diemTB < 7.7)
                return "Khá";
            else if (diemTB >= 5.4 && diemTB < 7)
                return "Trung bình";
            else
                return "Yếu";
        }
    }
}
