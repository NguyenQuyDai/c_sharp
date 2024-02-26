using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen n:");
            int n = int.Parse(Console.ReadLine());
            string[] don = {"", "mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin" };
            string[] chuc = { "","muoi", "hai muoi", "ba muoi", "bon muoi", "nam muoi", "sau muoi", "bay muoi", "tam muoi", "chin muoi" };
            string[] tram = { "","mot tram", "hai tram", "ba tram", "bon tram", "nam tram" , "sau tram", "bay tram", "tam tram", "chin tram" };
            int hangTram = n / 100;
            int hangChuc = (n / 10) %10;
            int hangDonVi = (n % 100)%10;
            Console.WriteLine($"So {n} doc duoc la:{tram[hangTram]} {chuc[hangChuc]} {don[hangDonVi]}");


        }
    }
}
