using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lesson1.Model
{
    public class Token
    {
        [Key]
        public int Id { get; set; }

        public int  UserId { get; set; }

        
        public string StrToken { get; set; }

        public int MyProperty { get; set; }
        public string ExpireAt { get;  set; }
    }
}
