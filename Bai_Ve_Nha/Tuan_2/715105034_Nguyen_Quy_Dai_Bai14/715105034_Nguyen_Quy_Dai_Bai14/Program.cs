using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hay nghi mot so nguyen: ");

            
            int soNguoiChoiNghi = int.Parse(Console.ReadLine());

            
            int ketQua = (soNguoiChoiNghi * 2 - 4) / 2 + 2;

           
            Console.WriteLine($"So ban da nghi la: {ketQua}");

            Console.WriteLine("Chuong trinh da doan xong. Cam on ban da tham gia!");
        }
    }
}
