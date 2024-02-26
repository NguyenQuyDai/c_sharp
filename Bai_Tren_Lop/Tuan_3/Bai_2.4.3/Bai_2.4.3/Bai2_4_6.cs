using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._4._3
{
    internal class Bai2_4_6
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thang:");
            int thang = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao lai xuat:");
            double lai = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao so tien gui:");
            long tien = long.Parse(Console.ReadLine());
            for(int i = 1; i <= thang; i++)
            {
                tien +=(long) (tien * 7.2)/100;
            }
            Console.WriteLine(tien.ToString());
        }
    }
}
