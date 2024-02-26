using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int n = 1;
            while(sum < 2.101999)
            {
                sum += 1.0 / (2 * n - 1);
                n++;
            }
            n = n - 1;
            Console.WriteLine($"Cau a:{n}");
            double cauB = 0;
            int tmp = 1;
            while(Math.Exp(tmp)-1999*Math.Log10(tmp)<2000)
            {
                tmp++;
            }
            tmp -= 1;
            Console.WriteLine($"Cau b:{tmp}");
        }
    }
}
