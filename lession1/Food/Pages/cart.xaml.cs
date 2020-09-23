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
           CartList.ItemsSource = SQLiteHelper.Select_carts();
        }

       

      

        private async void xoa_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Carts carts = CartList.SelectedItem as Carts;
            ContentDialog deleteFileDialog = new ContentDialog
            {
                Title = "Delete product Favourite?",
                Content = " Do you want to delete it?",
                PrimaryButtonText = "Delete",
                CloseButtonText = "Cancel"
            };

            ContentDialogResult result = await deleteFileDialog.ShowAsync();

            // Delete the file if the user clicked the primary button.
            /// Otherwise, do nothing.
            if (result == ContentDialogResult.Primary)
            {
                SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_product(); //tao bang
                SQLiteConnection sQLiteConnection = sQLiteHelper.sQLiteConnection;
                var sqlString = "DELETE FROM Carts WHERE id = ?";
                var stt = sQLiteConnection.Prepare(sqlString);
                stt.Bind(1, carts.id);
                stt.Step();
                GetCart();
            }

        }

        private void cong_Click(object sender, RoutedEventArgs e)
        {
            List<Carts> arr = SQLiteHelper.Select_carts();
            int quantity = 0;
            Carts carts = CartList.SelectedItem as Carts;

            if (carts != null)
            {
                SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_carts();
                SQLiteConnection qLiteConnection = sQLiteHelper.sQLiteConnection;

                foreach (Carts cart in arr)
                {
                    if (carts.id == cart.id)
                    {
                         quantity = cart.quantity;
                        quantity++;
                    }
                }
                var sql = "UPDATE Carts SET quantity = ? where id =?";

                var sttCreate = qLiteConnection.Prepare(sql);
                sttCreate.Bind(1, quantity);
                sttCreate.Bind(2, carts.id);
                sttCreate.Step();
                GetCart();
            }
        }

        private void tru_Click(object sender, RoutedEventArgs e)
        {
            List<Carts> arr = SQLiteHelper.Select_carts();
            int quantity;
            Carts carts = CartList.SelectedItem as Carts;
            string sql;
            if (carts != null)
            {
                SQLiteHelper sQLiteHelper = SQLiteHelper.createInstance_carts();
                SQLiteConnection qLiteConnection = sQLiteHelper.sQLiteConnection;
               
                foreach (Carts cart in arr)
                {
                    if (carts.id == cart.id)
                    {
                        quantity = cart.quantity;
                        quantity--;

                        if (quantity <= 0)
                        {
                            sql = "delete from Carts where id = ? ";
                            var sttCreate = qLiteConnection.Prepare(sql);
                            sttCreate.Bind(1, carts.id);
                            sttCreate.Step();
                        }
                        else
                        {
                            sql = "UPDATE Carts SET quantity = ? where id =?";
                            var sttCreate = qLiteConnection.Prepare(sql);
                            sttCreate.Bind(1, quantity);
                            sttCreate.Bind(2, carts.id);
                            sttCreate.Step();
                            
                        }
                         break;
                    }
                   
                }
                GetCart();
            }
        }
    }
}
