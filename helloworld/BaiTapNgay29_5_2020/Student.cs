using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay29_5_2020
{
    class Student
    {
         protected string nameStudent { get; set; }

        protected int age { get; set; }
        protected string id_student { get; set; }
        protected string address { get; set; }

        protected string email;
        protected string _email {
            get 
            {
                return email;
            }

            set 
            {
                if (value.Contains("@gmail.com")) {
                    this.email = value;
                }
            }
        }
        protected int phone { get; set; }
        protected string id_Parents { get; set; }




    }

}
