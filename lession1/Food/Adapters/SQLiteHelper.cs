using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food3.Adapters
{
    class SQLiteHelper
    {
        private readonly string DB_Name = "food.db";
        private static SQLiteHelper _sQLiteHelper;

        public static SQLiteHelper createInstance()
        {
            if (_sQLiteHelper == null)
            {
                var sql = @"CREATE TABLE IF NOT EXISTS Products(id integer primary key, name varchar(200), image varchar(200), description varchar(200), price integer)";
                _sQLiteHelper = new SQLiteHelper(sql);
            }
            return _sQLiteHelper;
        }
        //tao ket noi
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
        // tao table
        private void CreateTable(string sql)
        {
           
            var statement = sQLiteConnection.Prepare(sql);
            statement.Step();
        }

        public static SQLiteHelper createInstance_Cart()
        {
            if (_sQLiteHelper == null)
            {
                var sql = @"CREATE TABLE IF NOT EXISTS Cartss(id integer primary key, name varchar(200),
                 image varchar(200), price integer,qty integer)";
                _sQLiteHelper = new SQLiteHelper(sql);
            }
            return _sQLiteHelper;
        }

    }
}
