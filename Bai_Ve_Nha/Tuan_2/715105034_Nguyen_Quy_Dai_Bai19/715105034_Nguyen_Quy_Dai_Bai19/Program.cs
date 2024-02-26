using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so thu 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu 2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu 3:");
            int num3 = int.Parse(Console.ReadLine());
            int max = num1;
            if (num2 > max) max = num2;
            else max = num3;
            Console.WriteLine($"Gia tri lon nhat la:{max}");
        }
    }
}
