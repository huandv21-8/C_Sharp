using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay01_06_2020
{
    [Serializable]
    class ClassRoom
    {
        public string nameClass { get; set; }
        public string addressClass { get; set; }

        List<Student> listStudent { get; set; }

        public ClassRoom() {
            listStudent = new List<Student>();
        }
        public ClassRoom(string nameClass, string addressClass, List<Student> listStudent)
        {
            this.nameClass = nameClass;
            this.addressClass = addressClass;
            this.listStudent = listStudent;
        }

        public void input()
        {
            Console.WriteLine("Enter name class: ");
            nameClass = Console.ReadLine();
            Console.WriteLine("Enter address class: ");
            addressClass = Console.ReadLine();

            for(; ; )
            {
                Student std = new Student();
                std.input();
                listStudent.Add(std);
                Console.Write("Do you want to continue ? (y/n)");
                String a = Console.ReadLine();
                if (a.Equals("n"))
                {
                    break;
                }
            }

        }

        public void display()
        {
            Console.WriteLine("Name class: {0}, address class: {1}", nameClass, addressClass);
            foreach(Student std in listStudent)
            {
                std.display();
            }
        }
    }
}
