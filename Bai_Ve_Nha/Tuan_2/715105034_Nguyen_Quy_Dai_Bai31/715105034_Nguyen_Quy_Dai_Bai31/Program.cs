using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char s;
            int thuong = 0, hoa = 0, so = 0;
            do
            {
                s = Console.ReadKey().KeyChar;
                if (s >= 'a' && s <= 'z') thuong++;
                else if (s >= 'A' && s <= 'Z') hoa++;
                else so++;
            } while (s != '.');
            int total = thuong + hoa + so;
            int max = thuong;
            if (max < hoa) max = hoa;
            else  max = so;
            Console.WriteLine($"\nSo chu cai viet hoa la:{hoa},so chu so la:{so},so chu thuong la:{thuong},tong cac chu so la:{total},Loai ki tu nhieu nhat la:{max}");
        }
    }
}
