using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay22_5_2020
{
    class Hotel : InputOutput
    {

        public string idHotel { get; set; }
        public string nameHotel { get; set; }
        public string addressHotel { get; set; }
        public string hotelType { get; set; }

        public List<Room> listRoom { get; set; }

        public Hotel() {
            listRoom = new List<Room>();
        }

        public Hotel(string idHotel, string nameHotel, string addressHotel, string hotelType )
        {
            this.idHotel = idHotel;
            this.nameHotel = nameHotel;
            this.addressHotel = addressHotel;
            this.hotelType = hotelType;
        }

       public void Input()
        {
            Console.WriteLine("Enter information hotel: ");
            Console.WriteLine("Enter hotel id: ");
            idHotel = Console.ReadLine();  
            Console.WriteLine("Enter hotel name: ");
            nameHotel = Console.ReadLine();
            Console.WriteLine("Enter hotel address: ");
            addressHotel = Console.ReadLine();
            Console.WriteLine("Enter hotel type: ");
            hotelType = Console.ReadLine();

            Console.Write("Numbers of rooms: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                Console.WriteLine("Enter information room {0}: ", (i+1));
                Room room = new Room();
                room.Input();
                listRoom.Add(room);
            }

        }
        public void Display()
        {
            Console.WriteLine("id hotel: {0}, name hotel: {1}, address hotel: {2}, hotel type: {3}", idHotel, nameHotel, addressHotel, hotelType);
            foreach(Room room1 in listRoom)
            {
                room1.Display();
            }
        }


    }


}
