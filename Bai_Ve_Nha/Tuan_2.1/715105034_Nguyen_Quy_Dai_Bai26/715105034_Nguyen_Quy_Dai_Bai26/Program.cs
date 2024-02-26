using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai26
{
    internal class Program
    {
        static double TinhGiaTriBieuThuc(double giaTri, int lanLap)
        {
            if (lanLap == 0)
            {
                return Math.Sqrt(giaTri);
            }
            else
            {
                double ketQuaTrong = TinhGiaTriBieuThuc(giaTri, lanLap - 1);
                return Math.Sqrt(giaTri + ketQuaTrong);
            }
        }
        static void Main(string[] args)
        {
            double giaTriBanDau = 3;
            Console.WriteLine("Nhap so lan lap:");
            int soLanLap = int.Parse(Console.ReadLine());

            double ketQua = TinhGiaTriBieuThuc(giaTriBanDau, soLanLap);

            Console.WriteLine($"Bắt đầu với giá trị: {giaTriBanDau}");
            Console.WriteLine($"Số lần lặp: {soLanLap}");
            Console.WriteLine($"Giá trị của biểu thức là: {ketQua}");
        }
    }
}
