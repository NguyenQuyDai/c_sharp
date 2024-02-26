using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai15
{
    internal class Program
    {
        static bool checkChar(char c)
        {
            if((c >= 'a'&& c<='z') ||( c >= 'A' && c<='Z'))
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap vao mot ky tu:");
            char ch = Console.ReadKey().KeyChar;
            if (checkChar(ch))
            {
                Console.WriteLine("\nLa chu cai!");
            }
            else
            {
                Console.WriteLine("\nKhong la chu cai!");
            }
        }
    }
}
