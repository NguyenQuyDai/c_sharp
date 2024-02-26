using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai30
{
    internal class Program
    {
        static bool snt(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            for(int i = 3; i<= (int) Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int prevPrime = 2;

            for (int i = 3; i < 1000; i += 2)
            {
                if (snt(i))
                {
                    if (i - prevPrime == 2)
                        Console.WriteLine($"({prevPrime}, {i})");

                    prevPrime = i;
                }
            }
        }
    }
}
