using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so b:");
            double b = double.Parse(Console.ReadLine());
            double tong = a + b;
            double hieu = a - b;
            double tich = a * b;
            double thuong = a / b;
            Console.WriteLine($"Tong:{tong},Hieu:{hieu},Tich:{tich},Thuong:{thuong}");
        }
    }
}
