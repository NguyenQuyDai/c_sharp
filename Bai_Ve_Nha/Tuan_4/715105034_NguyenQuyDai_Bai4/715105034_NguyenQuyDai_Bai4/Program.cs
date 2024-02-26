using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào số khách hàng:");
            int n = int.Parse(Console.ReadLine());
            Customer[] customers = new Customer[n];
            for(int i = 0; i < n; i++)
            {
                customers[i] = new Customer();
                customers[i].nhap();
            }
            for (int i = 0; i < n; i++)
            {
                customers[i].xuat();
            }
            }
    }
}
