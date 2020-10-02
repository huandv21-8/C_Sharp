using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace Practical.Adapter
{
    class sqlLiteHelper
    {
        private readonly string DB_Name = "food.db";
        private static sqlLiteHelper _sQLiteHelper;

        public static sqlLiteHelper createInstance()
        {
            if (_sQLiteHelper == null)
            {
                var sql = @"CREATE TABLE IF NOT EXISTS user(id integer primary key, username varchar(200), pass varchar(200))";
                _sQLiteHelper = new sqlLiteHelper(sql);
            }
            return _sQLiteHelper;
        }
        //tao ket noi
        private sqlLiteHelper(string sql)
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
