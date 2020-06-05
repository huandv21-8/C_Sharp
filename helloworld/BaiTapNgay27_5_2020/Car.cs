using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay27_5_2020
{
    class Car: IInfor

    {
        protected string NameCar { get; set; }
        protected string Color { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter people information: ");
            Console.WriteLine("Enter car name: ");
            NameCar = Console.ReadLine();
           
            Console.WriteLine("Enter color: ");
            Color = Console.ReadLine();
        }
        public void ShowInfor()
        {
            Console.WriteLine("Name car: {0}, color: {1}", NameCar,Color);

        }
    }
}
