using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._4._3
{
    internal class Bai2_4_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao lua chon cua ban:");
            int chon = int.Parse(Console.ReadLine());
            Random random = new Random();
            int mayChon = random.Next(1, 3);
            Console.WriteLine($"Ban da chon:{chuyenSangLuaChon(chon)}");
            Console.WriteLine($"May da chon:{chuyenSangLuaChon(mayChon)}");
            Console.WriteLine($"Ket Qua:{ketQua(chon, mayChon)}");
        }
        static string chuyenSangLuaChon(int chon)
        {
            switch (chon)
            {
                case 1:
                    return "Keo";
                case 2:
                    return "Bua";
                case 3:
                    return "Bao";
                default:
                    return "";
            }
        }
        static string ketQua(int chon , int mayChon)
        {
            if (chon == mayChon)
            {
                return "Hoa";
            }else if(chon==1&&mayChon==3|| chon == 2 && mayChon == 1|| chon == 3 && mayChon == 2)
            {
                return "Ban thang!";
            }
            else
            {
                return "Ban thua";
            }
        }
    }
}
