using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ket qua:");
            Console.WriteLine($"{number1,-10:F2} {number2,-10:F2}");
        }
    }
}
