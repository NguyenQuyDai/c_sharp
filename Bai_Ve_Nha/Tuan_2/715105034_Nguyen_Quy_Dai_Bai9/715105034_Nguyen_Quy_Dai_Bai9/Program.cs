using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chon loai hinh:");
            Console.WriteLine("1. Hinh vuong");
            Console.WriteLine("2. Hinh chu nhat");
            Console.WriteLine("3. Hinh tron");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    hinhVuong();
                    break;
                case 2:
                    hinhChuNhat();
                    break;
                case 3:
                    hinhTron();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    break;
            }

        }
        static void hinhVuong()
        {
            Console.Write("Nhap canh cua hinh vuong: ");
            double side = double.Parse(Console.ReadLine());

            double area = side * side;
            double perimeter = 4 * side;

            Console.WriteLine($"Dien tich hinh vuong la: {area}");
            Console.WriteLine($"Chu vi hinh vuong la: {perimeter}");
        }

        static void hinhChuNhat()
        {
            Console.Write("Nhap chieu dai cua hinh chu nhat: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Nhap chieu rong cua hinh chu nhat: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine($"Dien tich hinh chu nhat la: {area}");
            Console.WriteLine($"Chu vi hinh chu nhat la: {perimeter}");
        }

        static void hinhTron()
        {
            Console.Write("Nhap ban kinh cua hinh tron: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine($"Dien tich hinh tron la: {area}");
            Console.WriteLine($"Chu vi hinh tron la: {circumference}");
        }
    }
}
