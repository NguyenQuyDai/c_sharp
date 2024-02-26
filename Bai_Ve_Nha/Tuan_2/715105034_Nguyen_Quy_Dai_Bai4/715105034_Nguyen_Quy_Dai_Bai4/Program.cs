using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so a:");
            double a = Math.Round(double.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Nhap vao so b:");
            double b = Math.Round(double.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Nhap vao so c:");
            double c = Math.Round(double.Parse(Console.ReadLine()), 2);
            Console.WriteLine($"\nPhuong trinh co dang {a:N2}x^2 {((b >= 0) ? "+" : "-")} {Math.Abs(b):N2}x {((c >= 0) ? "+" : "-")} {Math.Abs(c):N2} = 0");
        }
    }
}
