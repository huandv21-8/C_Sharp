using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay01_06_2020
{
   [Serializable]
     class Student
    {
        public string fullname{ get; set; }
        public string birthday { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string gender { get; set; }

        public Student() { }

        public Student(string fullname, string birthday, string email, string address, string gender)
        {
            this.fullname = fullname;
            this.birthday = birthday;
            this.email = email;
            this.address = address;
            this.gender = gender;
        }


        public void input()
        {
            Console.Write("Enter student name: ");
            fullname = Console.ReadLine();
            Console.Write("Enter student birthday: ");
            birthday = Console.ReadLine();

            Console.Write("Enter student email: ");
            email = Console.ReadLine();

            Console.Write("Enter student address: ");
            address = Console.ReadLine();

            Console.Write("Enter student gender: ");
            gender = Console.ReadLine();

        }
        public void display()
        {
            Console.WriteLine("name: {0}, birthday: {1}, email: {2}, address: {3}, gender: {4}", fullname, birthday, email, address, gender);
        }

      
    }
}
