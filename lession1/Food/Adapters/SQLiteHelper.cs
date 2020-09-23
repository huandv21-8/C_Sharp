using Food.Models;
using SQLitePCL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food.Adapters
{
    class SQLiteHelper
    {
        private readonly string DB_Name = "food.db";
        private static SQLiteHelper _sQLiteHelper_createTable;
       

        public static SQLiteHelper createInstance_product()
        {
            if(_sQLiteHelper_createTable == null)
            {
                 var sql =  @"CREATE TABLE IF NOT EXISTS Products(id integer primary key, name varchar(200), image varchar(200), description varchar(200), price integer)";
                _sQLiteHelper_createTable = new SQLiteHelper( sql);
            }
            return _sQLiteHelper_createTable;
        }

        public static List<Carts> Select_carts()
        {

            SQLiteHelper sQLiteHelper = createInstance_carts(); //tao bang
            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;

            var sqlString = "SELECT * FROM Carts";
            var stt = sQLiteConnection.Prepare(sqlString);
            List<Carts> arr = new List<Carts>();
            while (SQLiteResult.ROW == stt.Step())
            {
                var id = Convert.ToInt32(stt[0]);
                var name = (string)stt[1];
                var image = (string)stt[2];
                var description = (string)stt[3];
                var price = Convert.ToInt32(stt[4]);
                var quantity = Convert.ToInt32(stt[5]);

                arr.Add(new Carts(id, name, image, description, price, quantity));
            }
            return arr;
        }


        public static SQLiteHelper createInstance_carts()
        {
            if (_sQLiteHelper_createTable == null)
            {
                var sql = @"CREATE TABLE IF NOT EXISTS Carts(id integer primary key, name varchar(200), image varchar(200), description varchar(200), price integer,quantity integer)";
                _sQLiteHelper_createTable = new SQLiteHelper(sql);
            }
            return _sQLiteHelper_createTable;
        }

        private SQLiteHelper(string sql)
        {
            sQLiteConnection = new SQLiteConnection(DB_Name);
            CreateTable(sql);
        }

        public SQLiteConnection sQLiteConnection
        {
            get;
            private set;
        }

        private void CreateTable(string sql)
        {
            var statement = sQLiteConnection.Prepare(sql);
            statement.Step();
        }
    }
}
