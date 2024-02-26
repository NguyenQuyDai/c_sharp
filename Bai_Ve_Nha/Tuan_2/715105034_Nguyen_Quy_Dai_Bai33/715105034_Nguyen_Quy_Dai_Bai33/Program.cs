using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai33
{
    internal class Program
    {
        static int giaiThua(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n = 1;
            double cauA = 0;
            double e = Math.Pow(10, -6);
            while (1/Math.Pow(n,2) >= e)
            {
                cauA += 1 / Math.Pow(n, 2);
                n++;
            }
            double pi = Math.Sqrt(cauA * 6);
            Console.WriteLine($"Cau A: {pi}");
            Console.WriteLine("----------------------------------");
            Console.Write("Nhap vao x:");
            int nB = 0;
            double cauB=0;
            int x = int.Parse(Console.ReadLine());
            while (Math.Abs(Math.Pow(x, nB) / giaiThua(nB)) >= e)
            {
                cauB += (Math.Pow(x, nB) / (giaiThua(nB)));
                nB++;
            }
            Console.WriteLine($"Cau B: {cauB}");
            Console.WriteLine("----------------------------------");
            Console.Write("Nhap vao x:");
            int nC = 0;
            double cauC = 0;
            int xC = int.Parse(Console.ReadLine());
            while (Math.Abs(Math.Pow(xC, 2 * nC + 1) / giaiThua(2 * nC + 1)) >= e)
            {
                cauC += Math.Pow(-1, nC) * (Math.Pow(xC, 2 * nC + 1) / giaiThua(2 * nC + 1));
                nC++;
            }
            Console.WriteLine($"Cau C:{cauC}");
        }
    }
}
