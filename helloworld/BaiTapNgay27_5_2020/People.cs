using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay27_5_2020
{
    class People : IInfor
    {
        protected string name { get; set; }
        protected int Age { get; set; }

        protected string Address { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter people information: ");
            Console.WriteLine("Enter name: ");
           name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter address: ");
            Address = Console.ReadLine();

        }

        public void ShowInfor()
        {
            Console.WriteLine(" name: {0}, age: {1}, address: {2}", name, Age, Address);

        }
    }
}
