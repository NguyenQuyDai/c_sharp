using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai_29
{
    internal class Program
    {
        static bool soHoanChinh(int n)
        {
            int tong=0;
            for(int i= 1;  i< n; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                }
            }
            if(tong == n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < 1000; i++)
            {
                if (soHoanChinh(i)){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
