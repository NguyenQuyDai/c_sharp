using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThoiGian
{
    class ThoiGian
    {
        int nam, thang, ngay;
        int gio, phut, giay;
        public void thoiGianHienHanh()
        {
            Console.WriteLine("Hien thi thoi gian");
        }
        class Program
        {
            static void Main(string[] strings)
            {
                ThoiGian a = new ThoiGian();
                a.thoiGianHienHanh();
                Class1 b = new Class1();
                b.dislay();
            }
        }
    }
}
