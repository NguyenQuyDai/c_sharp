using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vap he so a ,b ,c, d, e ,f cua he phuong trinh:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            double D = a * e - d * b;
            double Dx = c * e - f * b;
            double Dy = a * f - d * c;
            Console.WriteLine($"x={Dx / D},y={Dy / D}");
        }
    }
}
