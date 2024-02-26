using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2_tuan_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot ky tu:");
            char kiTu = Console.ReadKey().KeyChar;

            Console.WriteLine("\nKi Tu vua nhap la: " + kiTu);

            int maASCII = (int)kiTu;
            Console.WriteLine("Ma ASCII của ki tu: " + maASCII);

            Console.ReadLine();
        }
    }
}
