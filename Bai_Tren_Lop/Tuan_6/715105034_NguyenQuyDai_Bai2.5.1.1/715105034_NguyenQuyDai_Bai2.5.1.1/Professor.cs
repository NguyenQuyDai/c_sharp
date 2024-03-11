using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai2._5._1._1
{
    internal class Professor:Person
    {
        public int SoBaiBao { get; set; }
        public Professor() { }
        public Professor(string hoTen, TDate ngaySinh, string queQuan,int soBaiBao):base(hoTen, ngaySinh, queQuan)
        {
            SoBaiBao = soBaiBao;
        }
        public override void inputData()
        {
            base.inputData();
            Console.WriteLine("Nhap vao so bai bao:");
            SoBaiBao = int.Parse(Console.ReadLine());
        }
        public bool giaoSuKietXuat()
        {
            return SoBaiBao >= 100;
        }
    }
}
