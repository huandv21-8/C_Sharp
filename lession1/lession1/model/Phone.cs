using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lession1.model
{
    class Phone
    {
        private char icon;
        private string name;
        private string sdt;
        private string typeContact;
        public static List<Phone> phones = new List<Phone>(0);
     

        public Phone(char icon, string name,string sdt , string typeContact)
        {
            Icon = icon;
            Name = name;
            Sdt = sdt;
            TypeContact = typeContact;
    }

        public char Icon
        {
            get => icon;
            set => icon = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }
        public string TypeContact
        {
            get => typeContact;
            set => typeContact = value;
        }
    }
}
