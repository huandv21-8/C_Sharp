using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay22_5_2020
{
    class Book : InputOutput
    {
      public DateTime dateBook { get; set; }
        public DateTime dateOutBook { get; set; }
        int CMND;
        int _CMND { 
            get{
                return CMND;
            }
            set {
                List < Customer > listCustomer = Manage.EnterCustomer();
                bool check = false;
                foreach( Customer list in listCustomer)
                {
                    if(CMND == list.CMND)
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    this.CMND = value;
                }
                else
                {
                    Customer cus = new Customer();
                    cus.Input();
                    listCustomer.Add(cus);
                     
                }
            }
        }

       
        
        string idHotel { get; set; }
        string idRoom { get; set; }

        public Book() { }
      /*  public Book(string dateBook, string dateOutBook, int CMND, string idHotel, string idRoom)
        {
            this.dateBook = dateBook;
            this.dateOutBook = dateOutBook;
            this.CMND = CMND;
            this.idHotel = idHotel;
            this.idRoom = idRoom;
        }*/
        public void Input()
        {
            Console.WriteLine("Enter date book: ");
            string dateIn  = Console.ReadLine();

            Console.WriteLine("Enter date out book: ");
           string dateOut = Console.ReadLine();

            Console.WriteLine("Enter CMND customer: ");
            CMND = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter id hotel: ");
            idHotel = Console.ReadLine();
            Console.WriteLine("Enter id room: ");
            idRoom = Console.ReadLine();
        }

        /*public  DateTime ConverDateTimeto(string value)
        {

        }*/

        public void Display()
        {
            Console.WriteLine(" date book: {0}, date out book: {1}, cmnd customer: {2}, id hotel: {3}, " +
                "id room: {4}", dateBook,dateOutBook,CMND,idHotel,idRoom);
        }
    }
}
