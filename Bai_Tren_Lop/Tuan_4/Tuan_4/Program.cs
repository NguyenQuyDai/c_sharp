using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Nhap vao so phan tu:");
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Day truoc khi nhan doi:");
            //for(int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("a[{0}]={1}", i, a[i]);
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        a[i] *= 2;
            //    }
            //}
            //Console.WriteLine("Day sau khi nhan doi:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("a[{0}]={1}", i, a[i]);
            //}
            //int max = a.Max();
            //Console.WriteLine("Phan tu lon nhat trong mang la:" + max);
            //int min = a.Min();
            //Console.WriteLine("Phan tu lon nhat trong mang la:" + min);
            //for(int i = 0; i < n-1; i++)
            //{
            //    for(int j = i +1; j < n; j++)
            //    {
            //        if (a[i] > a[j])
            //        {
            //            int tmp = a[i];
            //            a[i] = a[j];
            //            a[j] = tmp;
            //        }
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("a[{0}]={1}", i, a[i]);
            //}
            Console.Write("Nhap vao so hang cua ma tran:");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so hang cua ma tran:");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[m,n];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j< n; j++)
                {
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0}][{1}]={2} ", i, j, a[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
