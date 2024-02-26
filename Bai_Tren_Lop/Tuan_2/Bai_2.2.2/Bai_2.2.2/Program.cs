using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao gia tri x:");
            double x = double.Parse(Console.ReadLine());
            double bieuThucA = (x + 3) * (Math.Pow(x, 2) - 3 * x + 9);
            double bieuThucC = x * x - 2 * Math.Pow(x, 1.0/ 3.0);
            Console.WriteLine(bieuThucC);
        }
    }
}
