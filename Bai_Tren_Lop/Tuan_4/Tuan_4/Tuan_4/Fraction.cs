using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    class Fraction
    {
        private int tuSo, mauSo;
        public Fraction() { }
        public Fraction(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        public void nhap()
        {
            Console.Write("Nhap vao tu so:");
            tuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao mau so:");
            mauSo = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            rutGon();
            Console.WriteLine($"{tuSo}/{mauSo}");
        }
        private int ULCN(int a , int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private void rutGon()
        {
            int ucln = ULCN(tuSo, mauSo);
            tuSo = tuSo / ucln;
            mauSo = mauSo / ucln;
        }
        public Fraction cong(Fraction other)
        {
            int tuSoMoi = tuSo * other.mauSo + other.tuSo * mauSo;
            int mauSoMoi = mauSo * other.mauSo;
            return new Fraction(tuSoMoi, mauSoMoi);
        }
        public Fraction tru(Fraction other)
        {
            int tuSoMoi = tuSo * other.mauSo - other.tuSo * mauSo;
            int mauSoMoi = mauSo * other.mauSo;
            return new Fraction(tuSoMoi, mauSoMoi);
        }
        public Fraction nhan(Fraction other)
        {
            int tuSoMoi = tuSo * other.tuSo;
            int mauSoMoi = mauSo * other.mauSo;
            return new Fraction(tuSoMoi, mauSoMoi);
        }
        public Fraction chia(Fraction other)
        {
            int tuSoMoi = tuSo * other.mauSo;
            int mauSoMoi = mauSo * other.tuSo;
            return new Fraction(tuSoMoi, mauSoMoi);
        }
        public int soSanh(Fraction other)
        {
            Fraction hieu = this.tru(other);
            if (hieu.tuSo < 0)
                return -1;
            else if (hieu.tuSo > 0)
                return 1;
            else
                return 0;
        }
    }
}
