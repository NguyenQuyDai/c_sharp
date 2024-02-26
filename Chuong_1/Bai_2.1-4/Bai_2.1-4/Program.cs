using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao do dai canh a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao do dai canh b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao do dai canh c:");
            double c = double.Parse(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                double p = (a + b + c) / 2;
                double C = 2 * p;
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p-c));

            }
        }
    }
}
