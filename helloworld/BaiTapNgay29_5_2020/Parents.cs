using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay29_5_2020
{
    class Parents
    {
       protected string name { get; set; }
        protected string address { get; set; }
        protected int phone { get; set; }
        protected string id_Parents { get; set; }

        public Parents() { }

        protected void input()
        {
            Console.WriteLine("Enter information parents: ");
            Console.WriteLine("Enter name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter phone: ");
            phone = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter id parents: ");
            id_Parents = Console.ReadLine();

        }
        protected void display()
        {
            Console.WriteLine("name: {0}, address: {1}, phone: {2}, id parents: {3}",name,address,phone,id_Parents);
        }
    }
}
