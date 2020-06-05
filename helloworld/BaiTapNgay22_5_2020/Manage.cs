using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay22_5_2020
{
    class Manage
    {



        public static List<Customer> EnterCustomer( )
        {
            List<Customer> listCustomer = new List<Customer>();


            Console.WriteLine("Enter customers numbers: ");
            int a = int.Parse(Console.ReadLine());
            for(int i =0; i < a; i++)
            {
                Customer cus = new Customer();
                cus.Input();
                listCustomer.Add(cus);
            }
            return listCustomer;
        }
    }
}
