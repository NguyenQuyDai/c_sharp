using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(a, 2) - 2 * b + (a * b) / c);
            Console.WriteLine((Math.Pow(b, 2) - 4 * a * c) / (2 * a));
            Console.WriteLine(3 * a - Math.Pow(b, 3) - Math.Sqrt(c));
            Console.WriteLine(Math.Sqrt(((Math.Pow(a, 2)) / b)) - (4 * a / (b * c) + 1));
        }
    }
}
