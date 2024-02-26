using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            double b = double.Parse(Console.ReadLine());
            if(a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
            }
            else
            {
                Console.WriteLine($"Phuong trinh co nghiem:{-b / a}");
            }
        }
    }
}
