using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNgay25_5_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            int choose;
            do {
                ShowMenu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        for(; ; )
                        {
                            Product pro = new Product();
                            pro.Input();
                            products.Add(pro);
                            Console.WriteLine("Ban co muon nhap tiep ko ?(Y/N)");
                            String option = Console.ReadLine();
                            if (option.Equals("N"))
                            {
                                break;
                            }
                        }
                        break;
                    case 2:
                        foreach(Product pro in products)
                        {
                            pro.Display();
                        }
                        break;
                    case 3:
                        products.Sort((x, y) => y.Price.CompareTo(X.Price));
                        foreach(Product pro in products)
                        {
                            pro.Display();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thoat");
                        break;
                    default:
                        Console.WriteLine("Loi.");
                        break;
                }

            } while (choose != 4);
            Console.ReadKey();
        }
        static void ShowMenu()
        {
            Console.WriteLine("1.Nhập thông tin cho n sản phẩm");
            Console.WriteLine("2.Hiển thị thông tin vừa nhập");
            Console.WriteLine("3.Sắp xếp thông tin giảm dần theo giá và hiển thị");
            Console.WriteLine("4.Thoat");
            Console.Write("Choose: ");
        }
    }
}
