using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào số lượng sinh viên:");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] sv = new SinhVien[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập vào thông tin sinh viên thứ {i + 1}:");
                sv[i] = new SinhVien();
                sv[i].nhap();
            }
            Console.WriteLine("Danh sách sinh viên có điểm trung bình giảm dần là:");
            for(int i = 0; i < sv.Length - 1; i++)
            {
                for(int j = i +1; j < sv.Length; j++)
                {
                    if (sv[i].diemTB < sv[j].diemTB)
                    {
                        SinhVien tmp = sv[i];
                        sv[i] = sv[j];
                        sv[j] = tmp;
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                sv[i].xuat();
            }
            Console.WriteLine("Nhập vào mã sinh viên cần tìm:");
            string maSinhVien = Console.ReadLine();
            for(int i = 0;  i< sv.Length; i++)
            {
                if (sv[i].maSV == maSinhVien)
                {
                    sv[i].xuat();
                }
            }
        }
    }
}
