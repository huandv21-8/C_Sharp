using SQLitePCL;
using System;
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
