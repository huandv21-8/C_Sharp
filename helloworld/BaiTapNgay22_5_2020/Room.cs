using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay22_5_2020
{
    class Room : Hotel,InputOutput
    {
        public string roomName { get; set; }
        public float price { get; set; }
        public int floor { get; set; }
        public int numberPeople { get; set; }

        public string idRoom { get; set; }

        public Room() { }
        public Room(string roomName, float price, int floor, int numberPeople, string idRoom)
        {
            this.roomName = roomName;
            this.floor = floor;
            this.numberPeople = numberPeople;
            this.idRoom = idRoom;
        }

        public void Input()
        {
            Console.WriteLine("Enter room name: ");
            roomName = Console.ReadLine();
            Console.WriteLine("Enter price room: ");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter room floor: ");
            floor = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number people: ");
            numberPeople = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter room id: ");
            idRoom = Console.ReadLine();


        }

        public void Display()
        {
            Console.WriteLine(" room name: {0}, room price: {1}, room floor: {2}, number people: " +
                "{3}, room id: {4}", roomName,price,floor,numberPeople,idRoom);

        }

    }
}
