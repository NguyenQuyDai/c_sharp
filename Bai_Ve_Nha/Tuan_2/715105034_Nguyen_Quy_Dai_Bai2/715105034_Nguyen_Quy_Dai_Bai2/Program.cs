using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao ky tu:");
            char ch = Console.ReadKey().KeyChar;
            int maASCII = (int)ch;
            Console.WriteLine($"\nKy tu cua {ch} co ma acsii la:{maASCII}");
        }
    }
}
