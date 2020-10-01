using Food3.Adapters;
using Food3.Models;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food3.Services
{
    class FavoriteService
    {

        public static void InsertProduct(Product p)
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "INSERT INTO Products(id,name,image,description,price) VALUES(?,?,?,?,?)";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1, p.id);
            stt.Bind(2, p.name);
            stt.Bind(3, p.image);
            stt.Bind(4, p.description);
            stt.Bind(5, p.price);
            stt.Step();
        }

      
        public static void deleteProduct(int id)
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance();
            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var stt = sQLiteConnection.Prepare("DELETE FROM Products WHERE id = " + id);
            stt.Step();
        }

        //get data table 
        public static List<Product> getData()
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance();
            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "SELECT * FROM Products";
            var stt = sQLiteConnection.Prepare(sqlString);
            List<Product> arr = new List<Product>();
            while (SQLiteResult.ROW == stt.Step())
            {
                var id = Convert.ToInt32(stt[0]);
                var name = (string)stt[1];
                var image = (string)stt[2];
                var description = (string)stt[3];
                var price = Convert.ToInt32(stt[4]);

                arr.Add(new Product(id, name, image, description, price));
            }
            return arr;
        }
    }

}
