using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lession1.model;

namespace lession1.ViewModels
{
    class viewModels
    {
        public static List<Phone> listPhone = new List<Phone>();

        public viewModels()
        {


        }

        public List<Phone> Phones
        {
            get => listPhone;
        }
    }
}
