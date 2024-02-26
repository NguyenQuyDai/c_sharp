using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so x:");
            double f = 0;
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                f = 3 * x + Math.Sqrt(x);
            }
            else
            {
                f = Math.Exp(x) + 4;
            }
            Console.WriteLine($"Cau A:{f}");
            Console.WriteLine("---------------------------------------");
            Console.Write("Nhap vao so x:");
            int a = int.Parse(Console.ReadLine());
            double f1 = 0;
            if (a >= 1)
            {
                f1 = Math.Sqrt(Math.Pow(a, 2)+1);
            }else if (a <= -1)
            {
                f1 = Math.Pow(a, 2) + 2 * a - 1;
            }
            else
            {
                f1 = 3 * a + 5;
            }
            Console.WriteLine($"Cau B:{f1}");
        }
    }
}
