using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    internal class _2_4_1_3
    {
        static bool checkLength(string s)
        {
            if (s.Length < 9 || s.Length > 12)
            {
                return false;
            }
            else
                return true;
        }
        static bool checkStart(string s)
        {
            if (s[0] != '0')
                return false;
            else
                return true;
        }
        static bool checkNumber(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                {
                    return false;
                    break;
                }
             
            }
            return true;
        }
        static void Main(string[] args)
        {
            string s;
            Console.Write("Nhap vao so dien thoai:");
            s = Console.ReadLine();
            if (checkLength(s) && checkStart(s) && checkNumber(s))
            {
                Console.WriteLine("So dien thoai hop le!");
            }
            else
            {
                Console.WriteLine("So dien thoai khong hop le!");
            }
        }
        }
}
