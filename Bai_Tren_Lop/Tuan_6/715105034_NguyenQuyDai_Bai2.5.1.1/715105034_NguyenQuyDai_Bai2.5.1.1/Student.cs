using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai2._5._1._1
{
    internal class Student:Person
    {
        public double DiemTrungBinh { get; set; }
        public Student() { }
        public Student(string hoTen, TDate ngaySinh, string queQuan,double diemTrungBinh) : base( hoTen, ngaySinh, queQuan)
        {
            DiemTrungBinh = diemTrungBinh;
        }
        public override void inputData()
        {
            base.inputData();
            Console.Write("Nhap vao diem trung binh:");
            DiemTrungBinh = double.Parse(Console.ReadLine());
        }
        public bool hocSinhKietXuat()
        {
            return DiemTrungBinh > 9.5;
        }
    }
}
