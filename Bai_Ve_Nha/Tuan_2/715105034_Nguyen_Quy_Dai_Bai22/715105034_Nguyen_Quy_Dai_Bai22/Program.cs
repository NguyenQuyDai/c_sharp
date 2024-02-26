using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao nam:");
            int nam = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao thang:");
            int thang = int.Parse(Console.ReadLine());
            if( thang == 2)
            {
                if((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                {
                    Console.WriteLine("Co 29 ngay va la nam nhuan");
                }
                else
                {
                    Console.WriteLine("Co 28 ngay");
                }
            }else if(thang ==1 || thang ==3 || thang ==5 || thang==7 || thang ==8 || thang ==10 || thang == 12)
            {
                Console.WriteLine("Co 31 ngay");
            }
            else
            {
                Console.WriteLine("Co 30 ngay");
            }
        }
    }
}
