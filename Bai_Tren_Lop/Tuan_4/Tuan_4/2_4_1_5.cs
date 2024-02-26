using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_4
{
    internal class _2_4_1_5
    {
        static void Main(string[] args)
        {
            string s,t="";
            Console.Write("Nhap vao mot chuoi:");
            s = Console.ReadLine();
            s = s.ToLower();
            foreach(char x in s)
            {
                if (t.Contains(x) == false)
                {
                    int c = 0;
                    foreach(char y in s)
                    {
                        if (x == y) c++;
                    }
                    Console.WriteLine("{0}:{1}", x, c);
                    t += x;
                }
            }
            
        }
    }
}
