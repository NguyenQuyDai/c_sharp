using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Franction
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public Franction() { }
        public Franction(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }
        public static Franction operator+(Franction a, Franction b)
        {
            return new Franction(a.TuSo * b.MauSo + b.TuSo * a.MauSo, a.MauSo * b.MauSo);
        }
    }
}
