using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen(co 4 chu so):");
            int n = int.Parse(Console.ReadLine());

            int a = n / 1000; 
            int b = (n/ 100) % 10;
            int c = (n/ 10) % 10;
            int d = n % 10;

            int tong = a + b + c + d;
            Console.WriteLine($"Tong cua 4 chu so: {tong}, chu so dau: {a}, chu so cuoi: {d}");
        }
    }
}
