using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao ten than tuong cua ban:");
            String ten = Console.ReadLine();
            Console.WriteLine("Nhap vao quen quan cua ban:");
            String queQuan = Console.ReadLine();
            Console.WriteLine("Biet danh thich hop cua ban la: " + ten + " " + queQuan);
        }
    }
}
