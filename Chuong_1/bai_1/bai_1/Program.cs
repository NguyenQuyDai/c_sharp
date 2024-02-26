using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so thuc:");
            double soThuc = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vap so nguyen:");
            int soNguyen = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so nguyen dai:");
            long soNguyenDai = long.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao ky tu:");
            char kiTu = char.Parse(Console.ReadLine());
            Console.WriteLine("So thuc: " + soThuc);
            Console.WriteLine("So nguyen: " + soNguyen);
            Console.WriteLine("So nguyen dai: " + soNguyenDai);
            Console.WriteLine("Ki tu: " + kiTu);

            Console.ReadLine();
        }
    }
}
