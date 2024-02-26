using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhanSo ps1 = new PhanSo();
            ps1.nhap();
            PhanSo ps2 = new PhanSo();
            ps2.nhap();
            PhanSo ps3 = new PhanSo();
            ps3.nhap();
            PhanSo pA = ps1 + (ps2 * new PhanSo(2, 1)) + new PhanSo(3, 1);
            Console.Write("Ket qua a) p =");
            pA.xuat();
            PhanSo pB = PhanSo.Square(ps1 + ps2) + PhanSo.Square(ps1 - ps2);
            Console.Write("Ket qua b) p =");
            pB.xuat();
            PhanSo pC = PhanSo.Square(ps1) + PhanSo.Square(ps2) + PhanSo.Square(ps3) - ps1 * ps2 - ps2 * ps3 * (new PhanSo(2, 1)) + ps1 * ps3;
            Console.Write("Ket qua c) p =");
            pC.xuat();
        }
    }
}
