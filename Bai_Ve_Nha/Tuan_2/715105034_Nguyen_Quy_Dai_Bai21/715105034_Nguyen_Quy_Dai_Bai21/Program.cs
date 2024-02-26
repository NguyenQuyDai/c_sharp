using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so tu 2 den 8:");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 2:
                    Console.WriteLine("Thu hai");
                    break;
                case 3:
                    Console.WriteLine("Thu ba");
                    break;
                case 4:
                    Console.WriteLine("Thu tu");
                    break;
                case 5:
                    Console.WriteLine("Thu nam");
                    break;
                case 6:
                    Console.WriteLine("Thu sau");
                    break;
                case 7:
                    Console.WriteLine("Thu bay");
                    break;
                case 8:
                    Console.WriteLine("Chu nhat");
                    break;
                default:
                    Console.WriteLine("So khong hop le!");
                    break;
            }
        }
    }
}
