using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap ho ten");
            String hoTen = Console.ReadLine();
            Console.WriteLine("Nhap truong hoc:");
            String truong = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh:");
            int namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Xin chao " + hoTen + "....!\n" + hoTen + " nam nay " + (2024 - namSinh) + " tuoi,hoc sinh truong " + truong);
        }
    }
}
