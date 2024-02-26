using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction ps1 = new Fraction();
            ps1.nhapDL();
            Fraction ps2 = new Fraction();
            ps2.nhapDL();
            Fraction ps3 = ps1 + ps2;
            ps3.xuatDL();
            if(ps1 == ps2)
            {
                Console.WriteLine("2 Phân số bằng nhau");
            }
            else
            {
                Console.WriteLine("2 phân số không bằng nhau");
            }
        }
    }
}
