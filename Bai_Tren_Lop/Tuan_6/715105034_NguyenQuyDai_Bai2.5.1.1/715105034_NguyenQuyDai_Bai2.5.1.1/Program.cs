using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _715105034_NguyenQuyDai_Bai2._5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<Person> people = new List<Person>();
            Console.Write("Nhập số lượng người: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin cho người thứ {i + 1}:");
                Console.Write("Người này là sinh viên hay giáo sư? (S/G): ");
                char lc = char.ToUpper(Console.ReadLine()[0]);

                if (lc == 'S')
                {
                    Student student = new Student();
                    student.inputData();
                    people.Add(student);
                }
                else if (lc == 'G')
                {
                    Professor professor = new Professor();
                    professor.inputData();
                    people.Add(professor);
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập S cho sinh viên hoặc G cho giáo sư.");
                    i--; // Lặp lại vòng lặp hiện tại để nhận đầu vào hợp lệ.
                }
            }
            Console.WriteLine("\nCác cá nhân xuất sắc:");
            foreach(Person person in people)
            {
                if(person is Student st && st.hocSinhKietXuat())
                {
                    st.outputData();
                    Console.WriteLine();
                }
                else if(person is Professor professor && professor.giaoSuKietXuat())
                {
                    professor.outputData();
                    Console.WriteLine();
                }
            }
        }
    }
}
