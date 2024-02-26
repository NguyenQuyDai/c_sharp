using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    internal class _2_4_1_1
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so phan tu:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i< n; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Day truoc khi nhan la:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }
            Console.WriteLine("Day sau khi nhan la:");
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    a[i] *= 2;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }
            int max = a.Max();
            int min = a.Min();
            Console.WriteLine($"Phan tu lon nhan trong mang la:{max}\nPhan tu nho nhat trong mang la:{min}");
            Array.Sort(a);
            Console.WriteLine("Mang so khi sap xep la:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }
        }
    }
}
