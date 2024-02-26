using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao ban kinh R:");
            double R = double.Parse(Console.ReadLine());
            double S = 4 * Math.PI * Math.Pow(R, 2);
            double V = (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
            Console.WriteLine($"Dien tich:{S} va The tich cua hinh cau:{V}");
        }
    }
}
