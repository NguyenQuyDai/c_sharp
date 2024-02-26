using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Franction p = new Franction();
            p.nhap();
            p.xuat();
            Franction p2 = new Franction();
            p2.nhap();

            Franction p3 = p.cong(p2);
            Console.Write("Phép cộng hai phân số là:");
            p3.xuat();

        }
    }
}
