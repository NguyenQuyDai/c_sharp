using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai28
{
    internal class Program
    {
        static int tich(int n)
        {

            int fNumber = n / 10;
            int sNumber = n % 10;
            return fNumber * sNumber;
        }
        static int tong(int n)
        {
            int fNumber = n / 10;
            int sNumber = n % 10;
            return fNumber + sNumber;
        }
        static void Main(string[] args)
        {
            for(int i = 10; i < 100; i++)
            {
                if(tich(i) == 2 * tong(i))
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
