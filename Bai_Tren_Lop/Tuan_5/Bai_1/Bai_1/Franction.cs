using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    internal class Franction
    {
        int tuSo, mauSo;
        public Franction() { }

        public Franction(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        private int UCLN(int a,int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }
        public void nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào tử số:");
            tuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào mẫu số:");
            mauSo = int.Parse(Console.ReadLine());
        }
        public void RutGon()
        {
            int ucln = UCLN(tuSo, mauSo);
            tuSo /= ucln;
            mauSo /= ucln;
        }
        public void xuat()
        {
            RutGon();
            Console.WriteLine($"Phân số là:{tuSo}/{mauSo}");
        }
        public Franction cong(Franction psKhac)
        {
            int tuSoMoi = tuSo * psKhac.mauSo + mauSo * psKhac.tuSo;
            int mauSoMoi = mauSo * psKhac.mauSo;
            return new Franction(tuSoMoi, mauSoMoi);
        }
        public Franction tru(Franction psKhac)
        {
            int tuSoMoi = tuSo * psKhac.mauSo - mauSo * psKhac.tuSo;
            int mauSoMoi = mauSo * psKhac.mauSo;
            return new Franction(tuSoMoi, mauSoMoi);
        }
        public Franction tich(Franction psKhac)
        {
            int tuSoMoi = tuSo*psKhac.tuSo;
            int mauSoMoi = mauSo * psKhac.mauSo;
            return new Franction(tuSoMoi, mauSoMoi);
        }
        public Franction chia(Franction psKhac)
        {
            int tuSoMoi = tuSo * psKhac.mauSo;
            int mauSoMoi = mauSo * psKhac.tuSo;
            return new Franction(tuSoMoi, mauSoMoi);
        }
        
    }
}
