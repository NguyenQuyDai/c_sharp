using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { set; get; }
        public int SoCToThTrc { get; set; }
        public int SoCToThNay { get; set; }
        public Customer() { }
        public Customer(string name,string address,int soCToThTrc,int soCToThNay)
        {
            Name = name;
            Address = address;
            SoCToThTrc = soCToThTrc;
            SoCToThNay= soCToThNay;
        }

        public virtual void input()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào họ tên chủ hộ:");
            Name = Console.ReadLine();
            Console.Write("Nhập vào địa chỉ:");
            Address = Console.ReadLine();
            Console.Write("Nhập vào số công tơ tháng trước:");
            SoCToThTrc = int.Parse(Console.ReadLine());
            Console.Write("Nhập vào số công tơ tháng này:");
            SoCToThNay = int.Parse(Console.ReadLine());
        }
        public virtual int paymemt()
        {
            return (SoCToThNay - SoCToThTrc) * 1234;
        }
        public virtual void display()
        {
            Console.WriteLine($"Họ tên chủ hộ:{Name},\nĐịa chỉ:{Address},\nSố công tơ điện tháng trước:{SoCToThTrc},\nSố công tơ điện tháng này:{SoCToThNay}");
        }
    }
    class NewCustomer : Customer {
        public string TypeCustomer { get; set; }
        public NewCustomer() { }
        public NewCustomer(string name, string address, int soCToThTrc, int soCToThNay, string typeCustomer)
        : base(name, address, soCToThTrc, soCToThNay)
        {
            TypeCustomer = typeCustomer;
        }
        public override void input()
        {
            base.input();
            Console.Write("Nhập vào loại khách hàng(doanh nghiep hoac ho dan):");
            TypeCustomer = Console.ReadLine();
        }
        public override int paymemt()
        {
                if (TypeCustomer == "doanh nghiep")
                {
                    if ((SoCToThNay - SoCToThTrc) <= 100)
                        return (SoCToThNay - SoCToThTrc) * 2000;
                    else
                        return (SoCToThNay - SoCToThTrc) * 2500;
                }
                else
                {
                    if ((SoCToThNay - SoCToThTrc) <= 100)
                        return (SoCToThNay - SoCToThTrc) * 1234;
                    else
                        return (SoCToThNay - SoCToThTrc) * 1650;
                }
        }
        public override void display()
        {
            base.display();
            Console.WriteLine($"Loại khách hàng là:{TypeCustomer}");
            int Money = paymemt();
            Console.WriteLine($"Số tiền phải trả là:{Money}");
        }
    }
}
