using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai1
{
    class PhanSo
    {
        private int tuSo,mauSo;
        public PhanSo() { }
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
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
        public void xuat()
        {
            rutGon();
            Console.WriteLine($"{tuSo}/{mauSo}");
        }
        private int UCLN(int a,int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return a;
        }
        public void rutGon()
        {
            int ucln = UCLN(tuSo, mauSo);
            tuSo = tuSo / ucln;
            mauSo = mauSo / ucln;
        }
        public static PhanSo operator +(PhanSo a , PhanSo b)
        {
            int tuSoMoi = (a.tuSo * b.mauSo) + (b.tuSo * a.mauSo);
            int mauSoMoi = a.mauSo * b.mauSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            int tuSoMoi = (a.tuSo * b.mauSo) - (b.tuSo * a.mauSo);
            int mauSoMoi = a.mauSo * b.mauSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.tuSo*b.tuSo;
            int mauSoMoi = a.mauSo * b.mauSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.tuSo*b.mauSo;
            int mauSoMoi = a.mauSo*b.tuSo;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }
        // Tính Bình Phương
        // Square là một phương thức tĩnh 
        public static PhanSo Square(PhanSo a)
        {
            return a * a;
        }
        // so sánh 2 phân số
        public static int Compare(PhanSo a ,PhanSo b)
        {
            PhanSo tmp = a - b;
            if (tmp.tuSo<0)
                return -1;
            else if (tmp.tuSo > 0)
                return 1;
            else
                return 0;
        }
    }
}
