using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 9; i++)
            //{
            //    for(int j = 1; j<=9; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("Nhap so cua ban:");
            //int a = int.Parse(Console.ReadLine());
            //Random ramdom = new Random();
            //for (int i = 1; i <= 100; i++)
            //{

            //    int number = ramdom.Next(1, 100);
            //    Console.WriteLine($"Quay lan so {i}:{number}");
            //    if (number == a)
            //    {
            //        Console.WriteLine($"Chuc mung ban da trung so sau {i} luot quay");
            //        break;
            //    }
            //    if (i == 100)
            //    {
            //        Console.WriteLine("Chuc ban may man lan sau!");
            //    }
            //}
            Console.Write("Nhap vao so a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"UCLN={UCLN(a,b)}");
            Console.WriteLine($"BCNN={a * b / UCLN(a, b)}");
         
        }
        static int UCLN(int a , int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
                return UCLN(b, a % b);
        }
    }
}
