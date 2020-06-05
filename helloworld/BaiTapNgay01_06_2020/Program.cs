using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace BaiTapNgay01_06_2020
{
    class Program
    {

        static void Main(string[] args)
        {
            List<ClassRoom> classList = new List<ClassRoom>();
            int choose;
            do {
                Console.WriteLine("1. Nhập thông tin sinh viên từ file json");
                Console.WriteLine("2. Hiển thị thông tin sinh viên");
                Console.WriteLine("3. Lưu thông tin mỗi lớp học vào 1 file ten_lop.obj");
                Console.WriteLine("4. thoat");
                Console.Write("Enter choose: ");
                choose = int.Parse(Console.ReadLine());

                switch (choose) 
                {
                    case 1:
                       classList = ReadData();
                        break;
                    case 2:
                        foreach(ClassRoom cr in classList)
                        {
                            cr.display();
                        }
                        break;
                    case 3:
                        SaveFiles(classList);
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            
            } while (choose != 4);
            Console.ReadLine();
        }
        static List<ClassRoom> ReadData( )
        {
            //B1. Doc noi dung data.json
            var content = System.IO.File.ReadAllText(@"D:\Admin\Documents\XML_JSON\JSON\data.json");

           
            //B2. Convert JSON thanh Array Class Object trong C#
            List<ClassRoom> classRooms = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClassRoom>>(content);

            Console.WriteLine("Length: " + classRooms.Count);


            foreach(ClassRoom cr in classRooms)
            {
                cr.display();
            }
            return classRooms;

            //  Console.WriteLine(content);
        }

        static void SaveFiles(List<ClassRoom> classRooms)
        {
            foreach (ClassRoom classroom in classRooms)
            {
                //luu tung object classroom vao file Name.obj
                using (Stream stream = File.Open(classroom.nameClass + ".obj", FileMode.Create))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFormatter.Serialize(stream, classroom);
                }
            }
            //read file => object
            /**using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }*/
        }

    }
}
