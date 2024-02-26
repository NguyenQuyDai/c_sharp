using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao chu so thu 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao chu so thu 2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao chu so thu 3:");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao chu so thu 4:");
            int num4 = int.Parse(Console.ReadLine());
            int total = num1 + num2 + num3 + num4;
            int hangChuc = total / 10;
            int hangDonVi = total % 10;
            Console.WriteLine($"Tong cua 4 chu so: {total}, chu so hang chuc: {hangChuc}, chu so hang don vi: {hangDonVi}");
        }
    }
}
