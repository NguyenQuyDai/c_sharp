using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do dai canh a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhap do dai canh b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhap do dai canh c: ");
            double c = double.Parse(Console.ReadLine());

            if (LaTamGiac(a, b, c))
            {
                double chuVi = TinhChuVi(a, b, c);
                double dienTich = TinhDienTich(a, b, c);

                Console.WriteLine($"Chu vi cua tam giac la: {chuVi}");
                Console.WriteLine($"Dien tich cua tam giac la: {dienTich}");

                double h1 = TinhDoDaiDuongCao(a, b, c);
                double h2 = TinhDoDaiDuongCao(b, c, a);
                double h3 = TinhDoDaiDuongCao(c, a, b);

                double t1 = TinhDoDaiDuongTrungTuyen(a, b, c);
                double t2 = TinhDoDaiDuongTrungTuyen(b, c, a);
                double t3 = TinhDoDaiDuongTrungTuyen(c, a, b);

                double p1 = TinhDoDaiDuongPhanGiac(a, b, c);
                double p2 = TinhDoDaiDuongPhanGiac(b, c, a);
                double p3 = TinhDoDaiDuongPhanGiac(c, a, b);

                Console.WriteLine($"Do dai duong cao tu canh a la: {h1}");
                Console.WriteLine($"Do dai duong cao tu canh b la: {h2}");
                Console.WriteLine($"Do dai duong cao tu canh c la: {h3}");

                Console.WriteLine($"Do dai duong trung tuyen tu canh a la: {t1}");
                Console.WriteLine($"Do dai duong trung tuyen tu canh b la: {t2}");
                Console.WriteLine($"Do dai duong trung tuyen tu canh c la: {t3}");

                Console.WriteLine($"Do dai duong phan giac tu canh a la: {p1}");
                Console.WriteLine($"Do dai duong phan giac tu canh b la: {p2}");
                Console.WriteLine($"Do dai duong phan giac tu canh c la: {p3}");

                double rNoiTiep = TinhBanKinhDuongTronNoiTiep(a, b, c);
                double rNgoaiTiep = TinhBanKinhDuongTronNgoaiTiep(a, b, c);

                Console.WriteLine($"Ban kinh duong tron noi tiep la: {rNoiTiep}");
                Console.WriteLine($"Ban kinh duong tron ngoai tiep la: {rNgoaiTiep}");
            }
            else
            {
                Console.WriteLine("Ba canh nhap vao khong tao thanh mot tam giac.");
            }
        }
        static bool LaTamGiac(double a, double b, double c)
        {
            return a + b > c && b + c > a && c + a > b;
        }

        static double TinhChuVi(double a, double b, double c)
        {
            return a + b + c;
        }

        static double TinhDienTich(double a, double b, double c)
        {
            double p = TinhChuVi(a, b, c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static double TinhDoDaiDuongCao(double a, double b, double c)
        {
            return 2 * TinhDienTich(a, b, c) / a;
        }

        static double TinhDoDaiDuongTrungTuyen(double a, double b, double c)
        {
            return 0.5 * Math.Sqrt(2 * (Math.Pow(b, 2) + Math.Pow(c, 2)) - Math.Pow(a, 2));
        }

        static double TinhDoDaiDuongPhanGiac(double a, double b, double c)
        {
            return (2 * Math.Sqrt(b * c * (b + c - a))) / (b + c);
        }

        static double TinhBanKinhDuongTronNoiTiep(double a, double b, double c)
        {
            return TinhDienTich(a, b, c) / (TinhChuVi(a, b, c) / 2);
        }

        static double TinhBanKinhDuongTronNgoaiTiep(double a, double b, double c)
        {
            return (a * b * c) / (4 * TinhDienTich(a, b, c));
        }
    }
}
