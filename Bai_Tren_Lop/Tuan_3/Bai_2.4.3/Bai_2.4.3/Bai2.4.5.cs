using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._4._3
{
    internal class Bai2
    {
        static int UCLN(int a ,int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return UCLN(b, a % b);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Uoc chung lon nhat la:{UCLN(a,b)}");
            Console.WriteLine($"Boi chung nho nhat la:{a*b/UCLN(a,b)}")
;        }
    }
}
