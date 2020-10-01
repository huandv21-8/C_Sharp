using Food3.Adapters;
using Food3.Models;
using Food3.Services;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LayoutFavorite : Page
    {
        public LayoutFavorite()
        {
            this.InitializeComponent();
            GetFavourite();
        }

      
      
        private void GetFavourite()
        {

            ProductList.ItemsSource = FavoriteService.getData();
             
        }

        private async void FIclose_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Product product = ProductList.SelectedItem as Product; // lay doi tuong click trong ds favorite
            ContentDialog ms = new ContentDialog()
            {
                Title = "Thông Báo",
                Content="Bạn có muốn xóa sản phẩm khỏi danh sách",
                PrimaryButtonText="OK",
                CloseButtonText="Close"
   
            };
            ContentDialogResult result = await ms.ShowAsync();


            if (result == ContentDialogResult.Primary)
            {
                FavoriteService.deleteProduct(product.id);

                GetFavourite();
            }
           
            
        }
    }
}
