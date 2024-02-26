using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai16
{
    internal class Program
    {
        static string chanorle(int n)
        {
            if (n % 2 == 0)
                return "so chan";
            else
                return "so le";
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine($"So {a} La so am," + chanorle(a));
            }else
                Console.WriteLine($"So {a} La so duong," + chanorle(a));
        }
    }
}
