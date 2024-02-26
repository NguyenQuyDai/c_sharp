using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai5
{
    internal class Program
    {
        static double tinhGiaTriBieuThuc(double giaTri , double soLanLap)
        {
            if (soLanLap == 0)
            {
                return Math.Sqrt(giaTri);
            }
            else
            {
                double ketQuaBenTrong = tinhGiaTriBieuThuc(giaTri, soLanLap - 1);
                return Math.Sqrt(giaTri + ketQuaBenTrong);
            }
        }
        static double TinhGiaTriBieuThuc()
        {
            return TinhGiaTriPhanSo(1, 2);
        }

        static double TinhGiaTriPhanSo(double tuSo, double mauSo)
        {
            if (mauSo == 0)
                return 0;

            double phanSoTiepTheo = TinhGiaTriPhanSo(1, mauSo - 1);

            return tuSo / (mauSo + phanSoTiepTheo);
        }
        static void Main(string[] args)
        {
            double giaTriBanDau = 3;
            int soLanLap = 2;

            double ketQua = tinhGiaTriBieuThuc(giaTriBanDau, soLanLap);

            Console.WriteLine(ketQua);

            double cauB = TinhGiaTriBieuThuc();
            Console.WriteLine($"Gia tri cua bieu thuc la: {cauB}");
        }

    }
}
