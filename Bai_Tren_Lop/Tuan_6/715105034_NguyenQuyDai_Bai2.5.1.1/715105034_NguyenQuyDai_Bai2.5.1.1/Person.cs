using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai2._5._1._1
{
    internal class Person
    {
        public string HoTen { get; set; }
        public TDate NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public Person() {
            NgaySinh = new TDate();
        }
        public Person(string hoTen, TDate ngaySinh, string queQuan)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            QueQuan = queQuan;
        }
        public virtual void inputData()
        {
            Console.Write("Nhap vao ten:");
            HoTen = Console.ReadLine();
            NgaySinh.input();
            Console.Write("Nhap vao que quan:");
            QueQuan = Console.ReadLine();
        }
        public virtual void outputData()
        {
            Console.WriteLine("Ho ten: {0}", HoTen);
            Console.WriteLine("Ngay thang nam sinh:");
            NgaySinh.output();
            Console.WriteLine("Que quan: {0}", QueQuan);
        }
    }
}
