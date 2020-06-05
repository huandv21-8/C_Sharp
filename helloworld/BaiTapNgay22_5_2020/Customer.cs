using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay22_5_2020
{
    class Customer : InputOutput
    {
     public int CMND { get; set;}
        public string fullname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string address { get; set; }

        public Customer() { }

        public Customer(int CMND, string fullname, int age,string gender, string address)
        {
            this.CMND = CMND;
            this.fullname = fullname;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }

        public  void Input()
        {
            Console.WriteLine("Enter customer information: ");
            Console.Write("Enter CMND: ");
            CMND = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter fullname: ");
            fullname = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter gender: ");
            gender = Console.ReadLine();
            Console.Write("Enter address: ");
            address  = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("cmnd: {0}, fullname: {1},age: {2}, gender: {3}, address: {4}",CMND,fullname,age,gender,address);
        }
    }
}
