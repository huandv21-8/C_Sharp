using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay27_5_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IInfor> list = new List<IInfor>();
            Car car = new Car();
            People people = new People();

            car.Input();
            people.Input();
            list.Add(car);
            list.Add(people);

            showInfor(list);

        
            Console.ReadKey();

        }
        public static void showInfor(List<IInfor> list)
        {
              foreach(IInfor o in list)
              {
                o.ShowInfor();
             }

        }
    }
}
