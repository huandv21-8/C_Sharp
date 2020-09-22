using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Food.Adapters;
using Food.Models;
using SQLitePCL;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class cart : Page
    {
        public cart()
        {
            this.InitializeComponent();
            GetCart();
        }

        private void GetCart()
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_product(); //tao bang
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

                arr.Add(new Carts(id, name, image, description, price,quantity));
            }
            //Console.WriteLine(arr);
            //  var x = arr;
            CartList.ItemsSource = arr;
        }
    }
}
