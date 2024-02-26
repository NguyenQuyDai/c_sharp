using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Nhap ngay (dd): ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Nhap thang (mm): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam (yyyy): ");
            int year = int.Parse(Console.ReadLine());
            int a = (14 - month) / 12;
            int y = year - a;
            int m = month + 12 * a - 2;
            int dayOfWeek = (day + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;
            string[] daysOfWeek = { "Chu Nhat", "Thu Hai", "Thu Ba", "Thu Tu", "Thu Nam", "Thu Sau", "Thu Bay" };
            Console.WriteLine($"Thu cua ngay {day}/{month}/{year} là: {daysOfWeek[dayOfWeek]}");
        }
    }
}
