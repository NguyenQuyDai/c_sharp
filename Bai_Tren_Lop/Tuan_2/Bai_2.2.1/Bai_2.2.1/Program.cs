using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap vao so a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so b:");
            int b = int.Parse(Console.ReadLine());
            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            double thuong =(double) a / b;
            Console.WriteLine("tong:"+tong + "\nhieu:"+ hieu +"\ntich:"+ tich+"\nthuong:"+thuong.ToString("F2"));
        }
    }
}
