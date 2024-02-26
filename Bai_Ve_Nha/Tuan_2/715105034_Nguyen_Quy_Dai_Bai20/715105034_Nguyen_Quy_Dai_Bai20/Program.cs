using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap lan luot 3 canh cua tam giac:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if ((a + b > c) &&(a + c > b) && (b + c > a)){
                if(a == c && a == b)
                {
                    Console.WriteLine("La tam giac deu");
                }else if (a == c || a == b || b == c)
                {
                    Console.WriteLine("La tam giac can");
                }else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)|| Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)|| Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("La tam giac vuong");
                }
                else
                {
                    Console.WriteLine("La tam giac thuong!");
                }
            }
            else
            {
                Console.WriteLine("Khong phai la ba canh cua tam giac");
            }
        }
    }
}
