using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai2._5._1._1
{
    internal class TDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public TDate()
        {
            Day = 1;
            Month = 1;
            Year = 2000;
        }
        public TDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public void input()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào ngày:");
            Day = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào tháng:");
            Month = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào năm:");
            Year = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("{0}/{1}/{2}", Day, Month, Year);
        }
        public static bool operator >(TDate d1, TDate d2)
        {
            if (d1.Year > d2.Year)
                return true;
            else if (d1.Year < d2.Year)
                return false;
            else
            {
                if (d1.Month > d2.Month)
                    return true;
                else if (d1.Month < d2.Month)
                    return false;
                else
                {
                    return (d1.Day > d2.Day) ? true : false;
                }
            }
        }
        public static bool operator <(TDate d1, TDate d2)
        {
            if (d1.Year < d2.Year)
                return true;
            else if (d1.Year > d2.Year)
                return false;
            else
            {
                if (d1.Month < d2.Month)
                    return true;
                else if (d1.Month > d2.Month)
                    return false;
                else
                {
                    return (d1.Day < d2.Day) ? true : false;
                }
            }
        }
        public int tinhKhoangCach(TDate khac)
        {
            // Đổi cả hai ngày thành số ngày
            long d1 = Year * 365 + Day;
            for (int i = 0; i < Month - 1; i++)
            {
                if (i == 1) // Tháng 2
                {
                    if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
                        d1++; // Năm nhuận
                }
                d1 += 30 + (i % 2);
            }
            long d2 = khac.Year * 365 + khac.Day;
            for (int i = 0; i < khac.Month - 1; i++)
            {
                if (i == 1) // Tháng 2
                {
                    if ((khac.Year % 4 == 0 && khac.Year % 100 != 0) || (khac.Year % 400 == 0))
                        d2++; // Năm nhuận
                }
                d2 += 30 + (i % 2);
            }
            return (int)Math.Abs(d1 - d2);
        }

    }
}
