using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practical.Adapter;
using SQLitePCL;
using Windows.System;


namespace Practical.Services
{
    class service
    {
        
        public static void adduser(string username, string pass) {
            sqlLiteHelper sQLiteHelper = sqlLiteHelper.createInstance();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "INSERT INTO user(username,pass) VALUES(?,?)";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1, username );
            stt.Bind(2, pass);

            stt.Step(); 
        }

        public static List<model.Users> getUser()
        {
            sqlLiteHelper sQLiteHelper = sqlLiteHelper.createInstance();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "SELECT * FROM user";
            var stt = sQLiteConnection.Prepare(sqlString);
            List<model.Users> arr = new List<model.Users>();
            while (SQLiteResult.ROW == stt.Step())
            {
                var id = Convert.ToInt32(stt[0]);
                var username = (string)stt[1];
                var pass = (string)stt[2];


                arr.Add(new model.Users(username, pass));
            }
            return arr;
        }
    }
}
