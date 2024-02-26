using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao diem trung binh:");
            double tb = double.Parse(Console.ReadLine());
            if (tb > 10 || tb < 0)
            {
                Console.WriteLine("Diem trung binh khong hop le!");
            }
            else
            {
                if (tb <= 10 && tb >= 8)
                {
                    Console.WriteLine("Gioi!");
                }
                else if (tb < 8 && tb >= 5)
                {
                    Console.WriteLine("Kha");
                }
                else
                {
                    Console.WriteLine("Trung binh");
                }
            }
        }
    }
}
