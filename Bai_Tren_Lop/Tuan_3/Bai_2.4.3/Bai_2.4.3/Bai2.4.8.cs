using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._4._3
{
    internal class Bai2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so cua ban:");
            int a = int.Parse(Console.ReadLine());
            Random ramdom = new Random();
            for (int i = 1; i <= 100; i++)
            {

                int number = ramdom.Next(1, 100);
                Console.WriteLine($"Quay lan so {i}:{number}");
                if (number == a)
                {
                    Console.WriteLine($"Chuc mung ban da trung so sau {i} luot quay");
                    break;
                }
                if (i == 100)
                {
                    Console.WriteLine("Chuc ban may man lan sau!");
                }
            }
        }
    }
}
