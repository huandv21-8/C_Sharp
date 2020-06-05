using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThiCsharp
{
    class ContactManager
    {

        
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            int choose;
            do
            {
                show();
                choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter the number of contacts to add:");
                        int n = Int32.Parse(Console.ReadLine());
                        Input(n, hash);
                        break;
                    case 2:
                        Search(hash);
                        break;
                    case 3:
                        Display(hash);
                        break;
                    case 4:
                        Console.WriteLine("Exit success");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

            } while (choose != 4);

        }
        private static void show()
        {
            Console.WriteLine("1. Add new contact");
            Console.WriteLine("2. Find a contact by name");
            Console.WriteLine("3. Display contacts");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter choose: ");
        }

        private static void Input(int n, Hashtable hash)
        {
            for(int i =0; i < n; i++)
            {
                Phone phone = new Phone();
                phone.Input();
                hash.Add(phone.Name, phone.PhoneNumber);
            }
        }
        private static void Display(Hashtable hash)
        {
            ICollection key = hash.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + hash[k]);
            }

        }

        private static void Search(Hashtable hash) {
            ICollection key = hash.Keys;
            Console.WriteLine("Enter name to searh: ");
            string name = Console.ReadLine();
            foreach (string k in key)
            {

                if (name.Equals(k))
                {
                  Console.WriteLine(k + ": " + hash[k]);
                }
                else
                {
                    Console.WriteLine("No names in contacts");
                }
               
            }
        }

    }
}
