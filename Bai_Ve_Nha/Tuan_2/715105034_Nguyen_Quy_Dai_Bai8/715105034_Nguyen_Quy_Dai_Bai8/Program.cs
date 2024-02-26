using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so thu nhat:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu ba:");
            int c = int.Parse(Console.ReadLine());
            double tbCong = (a + b + c) / 3;
            double tbNhan = (a * b * c) / 3;
            Console.WriteLine($"Trung binh cong:{tbCong} Trung binh nhan{tbNhan}");
        }
    }
}
