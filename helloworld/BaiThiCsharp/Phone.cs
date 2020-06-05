using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThiCsharp
{
    class Phone
    {
        public string Name { get; set; }

        public int PhoneNumber { get; set; }
       
        public void Input()
        {
            bool ischeck = true;
            while (ischeck)
            {
                Console.Write("Enter name: ");
                Name = Console.ReadLine();
                if (string.IsNullOrEmpty(Name) == false)
                {
                    ischeck = false;
                }
                else
                {
                    Console.WriteLine("Enter error.");
                }
            }
                Console.WriteLine("Enter phone number: ");
                PhoneNumber = Int32.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("Name: {0}; phone number: {1}", Name, PhoneNumber);
        }

    }
}
