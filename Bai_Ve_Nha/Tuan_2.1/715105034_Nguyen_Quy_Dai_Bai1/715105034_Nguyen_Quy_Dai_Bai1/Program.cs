using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap nhiet do cao nhat trong ngay (do C):");
            double maxTemp = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap nhiet do thap nhat trong ngay (do C):");
            double minTemp = double.Parse(Console.ReadLine());

            double tempF = 65 - (maxTemp + minTemp) / 2;
            Console.WriteLine($"Nhiet do theo thang do F la: {tempF}");

            if (tempF > 0)
            {
                Console.WriteLine("Hom nay la nhiet do duong.");
            }
            else
            {
                Console.WriteLine("Hom nay la nhiet do am.");
            }
        }
    }
}
