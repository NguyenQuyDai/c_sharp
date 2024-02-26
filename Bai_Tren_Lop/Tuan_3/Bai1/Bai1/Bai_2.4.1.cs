using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Bai_2
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
