using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so n:");
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for(int i = 1; i <= n; i++)
            {
                sum1 += i;
            }
            Console.WriteLine($"Cau A:{sum1 / n}");
            double sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                sum2 += Math.Pow(i, 2);
            }
            Console.WriteLine($"Cau B:{Math.Sqrt(sum2)}");
        }
    }
}
