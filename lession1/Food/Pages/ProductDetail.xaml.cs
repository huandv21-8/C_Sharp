using Food.Adapters;
using Food.Models;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class ProductDetail : Page
    {
        public ProductDetail()
        {
            this.InitializeComponent();
        }

        private Product Detail
        {
            get;
            set;
        }
         
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Detail = e.Parameter as Product;
        }

        private void BtnLike_Click(object sender, RoutedEventArgs e)
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_product();

            SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "INSERT INTO Products(id,name,image,description,price) VALUES(?,?,?,?,?)";
            var stt = sQLiteConnection.Prepare(sqlString);
            stt.Bind(1, Detail.id);
            stt.Bind(2, Detail.name);
            stt.Bind(3, Detail.image);
            stt.Bind(4, Detail.description);
            stt.Bind(5, Detail.price);
            stt.Step();
            MainPage.mainFrame.Navigate(typeof(Favourite));
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_carts();
            SQLiteConnection qLiteConnection = sQLiteHelper.sQLiteConnection;
            var sqlString = "SELECT * FROM Carts";
            var stt = qLiteConnection.Prepare(sqlString);
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

            string sql = "INSERT INTO Carts(id , name,image,description, price, quantity) VALUES (?,?,?,?,?,?)";
            int quan = 1;

            foreach(Carts cart in arr)
            {
                if(cart.id == Detail.id)
                {
                    sql = "UPDATE Carts SET id = ? , name = ? ,image = ?,description = ?, price= ? , quantity = ? where id =" + cart.id;
                    quan = cart.quantity + 1;
                }
              
            }

            var sttCreate = qLiteConnection.Prepare(sql);
            sttCreate.Bind(1, Detail.id);
            sttCreate.Bind(2, Detail.name);
            sttCreate.Bind(3, Detail.image);
            sttCreate.Bind(4, Detail.description);
            sttCreate.Bind(5, Detail.price);
            sttCreate.Bind(6, quan );
            sttCreate.Step();

            MainPage.mainFrame.Navigate(typeof(cart));
        }
    }
}
