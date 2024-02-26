using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap can nang (kg):");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap chieu cao (m):");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap gioi tinh (nam/nu):");
            string gender = Console.ReadLine();

            double bmi = weight / (height * height);
            Console.WriteLine($"Chi so BMI cua ban la: {bmi}");

            if ((gender == "nam" && bmi > 27.8) || (gender == "nu" && bmi > 27.3))
            {
                Console.WriteLine("Ban dang bi beo phi.");
            }
            else
            {
                Console.WriteLine("Ban khong bi beo phi.");
            }

            if (bmi < 25)
            {
                Console.WriteLine("Nguy co bi dau tim cua ban thap.");
            }
            else if (bmi >= 25 && bmi <= 30)
            {
                Console.WriteLine("Nguy co bi dau tim cua ban trung binh.");
            }
            else
            {
                Console.WriteLine("Nguy co bi dau tim cua ban cao.");
            }
        }
    }
}
