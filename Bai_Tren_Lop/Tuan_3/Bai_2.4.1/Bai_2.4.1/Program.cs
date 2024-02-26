using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap nam sinh cua ban:");
            int namSinh = int.Parse(Console.ReadLine());
            if ((2024 - namSinh) >= 16)
            {
                Console.WriteLine("Xin chuc mung, ban da du tuoi lai xe may");
            }
            else
            {
                Console.WriteLine("Ban chua du tuoi lai xe may");
            }
        }
    }
}
