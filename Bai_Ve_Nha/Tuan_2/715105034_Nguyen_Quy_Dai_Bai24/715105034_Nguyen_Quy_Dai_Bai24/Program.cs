using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao tuoi cua cha:");
            int tuoiCha = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao tuoi cua con:");
            int tuoiCon = int.Parse(Console.ReadLine());
            if(tuoiCha <= 2*tuoiCon)
            {
                Console.WriteLine("Tuoi cha phai lon gap doi con");
            }
            else
            {
                int soNam = 0;
                while(tuoiCon*2 < tuoiCha)
                {
                    tuoiCha++;
                    tuoiCon++;
                    soNam++;
                }
                Console.WriteLine(soNam);
            }
        }
    }
}
