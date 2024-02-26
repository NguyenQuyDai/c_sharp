using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai4
{
    internal class Program
    {
        static bool LaSoNguyenTo(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Cac so nguyen to nho hon 100,000:");

            for (int i = 2; i < 100000; i++)
            {
                if (LaSoNguyenTo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    
}
