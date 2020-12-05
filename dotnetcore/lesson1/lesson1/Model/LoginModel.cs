using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lesson1.Model
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Pwd { get; set; }
    }

    public class LoginResult
    {

        public string Token { get; set; }

        public User User { get; set; }
        public bool Status { get => true; set; }
        public string Message { get; set; }
    }

   
}

