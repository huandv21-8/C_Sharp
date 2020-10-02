using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.model
{
    class Users
    {

        public string username { get; set; }
        public string pass { get; set; }

        public Users(string username, string pass){
            this.username = username;
            this.pass = pass;
            }
          
            
    }
}
