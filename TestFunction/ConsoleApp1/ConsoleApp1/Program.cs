using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Swap<T>(ref T a , ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
        static void Main(string[] args)
        {
            int a = 2;
            int b = 1;
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a:{a}, b:{b}");
        }
    }
}
