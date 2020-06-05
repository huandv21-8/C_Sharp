using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay20_5_2020_product
{
    class Employee
    {
        private string fullname { set; get; }

        private enum Gender
        { 
            Nam, Nu, Bede
        }
        private Gender gender { set; get; }


       
        private string address { get; set; }
        private string role { get; set; }
        private double _salary;
        private double salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 0)
                {
                    this._salary = value;
                }
                else
                {
                    Console.WriteLine("Luong phai lon hon 0.");
                }
            }
        }

        public Employee() { }


        public void input(){
            Console.WriteLine("Nhap ten :");
            fullname = Console.ReadLine();

            int i;
            do
            {
                Console.WriteLine("chon gioi tinh: ");
                Console.WriteLine("1.Nam ");
                Console.WriteLine("2.Nu ");
                Console.WriteLine("3.Bede ");
                 i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        gender = Gender.Nam;
                        break;
                    case 2:
                        gender = Gender.Nu;
                        break;
                    case 3:
                        gender = Gender.Bede;
                        break;
                }

            } while (i >3 && i<0 );

            Console.WriteLine("Nhap que quan : ");
            address = Console.ReadLine();
            Console.WriteLine("Nhap chuc vu :");
            role = Console.ReadLine();
            Console.WriteLine("Nhap tien luong : ");
            salary = Convert.ToDouble(Console.ReadLine());

        }

        public void display()
        {
            Console.WriteLine("Ten: {0}\nGioiTinh: {1}\nDia chi: {2}\nChuc vu: {3}\nLuong: {4}", fullname, gender, address, role, salary);
        }
    }
}
