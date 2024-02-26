using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai4
{
    internal class Customer
    {
        public string hoTen { get; set; }
        public string diaChi { get; set; }
        public int soCongToThTrc { get; set; }
        public int soCongToThNay { get; set; }

        public Customer() { }

        public Customer(string hoTen, string diaChi, int soCongToThTrc, int soCongToThNay)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soCongToThTrc = soCongToThTrc;
            this.soCongToThNay = soCongToThNay;
        }
        public void nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào họ tên chủ hộ:");
            hoTen = Console.ReadLine();
            Console.Write("Nhập vào địa chỉ:");
            diaChi = Console.ReadLine();
            Console.Write("Nhập vào số công tơ tháng trước:");
            soCongToThTrc = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số công tơ tháng này:");
            soCongToThNay = int.Parse(Console.ReadLine());
        }
        public int giaTien()
        {
            return (soCongToThNay - soCongToThTrc) * 1234;
        }
        public void xuat()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Họ tên chủ hộ:{hoTen}");
            Console.WriteLine($"Địa chỉ:{diaChi}");
            Console.WriteLine($"Số công tơ tháng trước:{soCongToThTrc}");
            Console.WriteLine($"Số công tơ tháng này:{soCongToThNay}");
            Console.WriteLine($"Số tiền điện là:{giaTien()}");
        }
    }
}
