using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            TDate d1 = new TDate();
            TDate d2 = new TDate();

            // Nhập và hiển thị ngày tháng
            Console.WriteLine("Nhập ngày thứ nhất:");
            d1.input();
            Console.WriteLine("Nhập ngày thứ hai:");
            d2.input();

            Console.Write("Ngày thứ nhất: ");
            d1.output();
            Console.Write("Ngày thứ hai: ");
            d2.output();
            if (d1 > d2)
                Console.WriteLine("Ngày thứ hai sớm hơn Ngày thứ nhất.");
            else if (d1 < d2)
                Console.WriteLine("Ngày thứ nhất sớm hơn Ngày thứ hai.");
            else
                Console.WriteLine("Hai ngày tháng là giống nhau.");

            // Tính khoảng cách giữa hai ngày tháng
            int kc = d1.tinhKhoangCach(d2);
            Console.WriteLine($"Khoảng cách giữa hai ngày tháng: {kc} ngày.");
            Console.ReadLine();
        }
    }
}
