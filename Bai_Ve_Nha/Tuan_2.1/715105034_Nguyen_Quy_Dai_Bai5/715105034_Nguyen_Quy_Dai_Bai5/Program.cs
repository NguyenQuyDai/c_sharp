using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int soLuong = int.Parse(Console.ReadLine());

            string[] danhSachSinhVien = new string[soLuong];

            for (int i = 0; i < soLuong; i++)
            {
                Console.Write($"Nhap ho ten sinh vien thu {i + 1}: ");
                danhSachSinhVien[i] = Console.ReadLine();
            }
            Array.Sort(danhSachSinhVien, (x, y) =>
            {
                string[] hoTenX = x.Split(' ');
                string[] hoTenY = y.Split(' ');

                int ketQua = String.Compare(hoTenX[hoTenX.Length - 1], hoTenY[hoTenY.Length - 1], StringComparison.Ordinal);

                if (ketQua == 0)
                {
                    ketQua = String.Compare(hoTenX[0], hoTenY[0], StringComparison.Ordinal);
                }

                return ketQua;
            });
            Console.WriteLine("\nDanh sach sinh vien sau khi sap xep:");
            foreach (var sinhVien in danhSachSinhVien)
            {
                Console.WriteLine(sinhVien);
            }
        }
    }
}
