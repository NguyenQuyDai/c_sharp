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
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhap so luong phan so:");
            int N = int.Parse(Console.ReadLine());
            Fraction[] fractions = new Fraction[N];
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhap vao phan so thu {i + 1}:");
                Fraction fraction = new Fraction();
                fraction.nhap();
                fractions[i] = fraction;
            }
            Console.WriteLine("\nDanh sách các phân số vừa nhập:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Phân số {i + 1}: ");
                fractions[i].xuat();
            }
            // tim phan so lon nhat
            Fraction max = fractions[0];
            Fraction min = fractions[0];
            for(int i =1; i < N; i++)
            {
                if (fractions[i].soSanh(max) > 0)
                {
                    max = fractions[i];
                }
                if (fractions[i].soSanh(min) < 0)
                {
                    min = fractions[i];
                }
            }
            Console.WriteLine("\nPhân số có giá trị lớn nhất là:");
            max.xuat();
            Console.WriteLine("\nPhân số có giá trị bé nhất là:");
            min.xuat();
            Console.WriteLine("\nTổng của 2 phân số max và min là");
            Fraction tong = max.cong(min);
            tong.xuat();
            Console.WriteLine("\nHiệu của 2 phân số max và min là");
            Fraction tru = max.tru(min);
            tru.xuat();
            Console.WriteLine("\nNhân của 2 phân số max và min là");
            Fraction nhan = max.nhan(min);
            nhan.xuat();
            Console.WriteLine("\nThương của 2 phân số max và min là");
            Fraction thuong = max.chia(min);
            thuong.xuat();
            for(int i = 0; i < N - 1; i++)
            {
                for(int j = i+1; j < N; j++)
                {
                    if (fractions[i].soSanh(fractions[j]) < 0)
                    {
                        Fraction temp = fractions[i];
                        fractions[i] = fractions[j];
                        fractions[j] = temp;
                    }
                }
            }
            Console.WriteLine("Danh sách phân số sau khi sắp xếp là:");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"Phân số {i + 1}: ");
                fractions[i].xuat();
            }
        }
    }
}
