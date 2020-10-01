using Food.Pages;

using Food.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
using Food3.Models;
using Food3.Pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Food3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static List<Product> FavoriteProduct;
        // public static List<Cart> listCart;
        public static Frame contentFrame;
        private readonly string stringUrl = String.Format("https://foodgroup.herokuapp.com/api/menu");
        public MainPage()
        {
            this.InitializeComponent();
            GetMenu();
            FavoriteProduct = new List<Product>();
        }
        public async void GetMenu()
        {
            HttpClient httpClient = new HttpClient();// shippner
            var response = await httpClient.GetAsync(stringUrl);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                Menu menu = JsonConvert.DeserializeObject<Menu>(stringContent);
                MN.ItemsSource = menu.data;
            }
        }


        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem menuItem = MN.SelectedItem as MenuItem;
            MainFrame.Navigate(typeof(Pages.Category), menuItem);
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            contentFrame = MainFrame;
            MainFrame.Navigate(typeof(Pages.Home));
        }

        private void btnFavorite_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(LayoutFavorite), FavoriteProduct);
        }



        private void FIhome_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Home));
        }

        private void FIheart_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(LayoutFavorite));
        }

        //show layout listcart order
        private void FIcart_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(ShowCart));
        }


    }
}