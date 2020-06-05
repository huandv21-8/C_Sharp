using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay20_5_2020_diemthi
{
    class StudentMark
    {
        private  string rollno;
        private   string _rollno 
        {
           
            
            get
            {
                return rollno;
            }


            set
            {
                    if (value.Length >= 6 && value.Length <= 12)
                    {
                        this.rollno = value;
                    }
                    else
                    {
                        Console.WriteLine("Rollno phai dai tu 6 den 12 ki tu.");
                    }
            }
        }

        public float mark;
        public float Mark
        {
            get
            {
                return mark;
            }
            set
            {
                if (mark >= 0 && mark <= 10)
                {
                    this.mark = Mark;
                }
                else
                {
                    Console.WriteLine("diem phai tu 0 <= diem <= 10 ");
                }
            }
        }
        public string Fullname { get; set; }
        public string Classroom { get; set; }
        public string Subject { get; set; }
        public StudentMark()
        {

        }
        public StudentMark(String rollno, String fullname, String classroom, String subject, float mark)
        {
            this.rollno = rollno;
            this.Fullname = fullname;
            this.Classroom = classroom;
            this.Subject = subject;
            this.Mark = mark;
        }
        public  void input()
        {
            Console.Write("Nhap ma sinh vien: ");
            rollno = Console.ReadLine();
            Console.Write("Nhap ten: ");
            Fullname = Console.ReadLine();
            Console.Write("Nhap lop: ");
            Classroom = Console.ReadLine();
            Console.Write("NHap mon: ");
            Subject = Console.ReadLine();
            Console.Write("Nhap diem: ");
            Mark = float.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("ma: {0}, ten: {1}, lop: {2}, mon: {3}, diem: {4}", rollno, Fullname, Classroom, Subject, Mark);
        }




        static void Main(string[] args)
        {
            
        }
    }
}
