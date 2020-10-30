using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical.Models
{
    public class Employee
    {
        [Key]
        public int Id_employee { get; set; }
        public string Name_employee { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }
}