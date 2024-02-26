using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_Nguyen_Quy_Dai_Bai27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so tu nhien: ");
            int number = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            while (number != 0)
            {
                stack.Push(number % 2);
                number /= 2;
            }

            Console.Write("so nhi phan la: ");

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.ReadLine();
        }
    }
    
}
