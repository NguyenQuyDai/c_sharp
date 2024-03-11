using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._5._1._1
{
    internal class Fraction
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public Fraction() { }
        public Fraction(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }
        public void nhapDL()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào tử số:");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào mẫu số:");
            MauSo = int.Parse(Console.ReadLine());
        }
        public int UCLN(int a , int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public void rutGon()
        {
            int ucln = UCLN(TuSo, MauSo);
            TuSo /= ucln;
            MauSo /= ucln;
        }
        public void xuatDL()
        {
            rutGon();
            Console.WriteLine($"Phân số:{TuSo}/{MauSo}");
        }
        public static Fraction operator+(Fraction a,Fraction b)
        {
            int tuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            int mauSo = a.MauSo * b.MauSo;
            return new Fraction(tuSo, mauSo);
        }
        public static Fraction operator-(Fraction a , Fraction b)
        {
            int tuSo = a.TuSo * b.MauSo - b.TuSo * a.MauSo;
            int mauSo = a.MauSo * b.MauSo;
            return new Fraction(tuSo, mauSo);
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            int tuSo = a.TuSo*b.TuSo;
            int mauSo = a.MauSo*b.MauSo;
            return new Fraction(tuSo, mauSo);
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            int tuSo = a.TuSo * b.MauSo;
            int mauSo = a.MauSo * b.TuSo;
            return new Fraction(tuSo, mauSo);
        }
    }
}
