using Food3.Models;
using Food3.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
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
    public sealed partial class Home : Page
    {
        
        private ProductServices _productServices = new ProductServices();
        public Home()
        {
            this.InitializeComponent();
            TodaySpecial();
        }
        public async void TodaySpecial()
        {
            ProductList productList = await _productServices.TodaySpecial();
            if (productList != null)
            {
                ProductList.ItemsSource = productList.data;
            }
        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Product product = ProductList.SelectedItem as Product;
            MainPage.contentFrame.Navigate(typeof(ProductDetail), product);
        }

      

        private async void tbSearch_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            List<Product> listSearch = new List<Product>();
           if(e.Key == Windows.System.VirtualKey.Enter)
            {
                ProductList productList = await _productServices.TodaySpecial();
                if(productList != null)
                {
                    foreach(var item in productList.data)
                    {
                        if (item.name.Contains(tbSearch.Text)) 
                        {
                            listSearch.Add(item);
                        }
                    }
                    // đổ dữ liệu lấy dc vào giao diện
                    ProductList.ItemsSource = listSearch;
                }
            }

        }

        private async void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Product> listSearch = new List<Product>();
            
                ProductList productList = await _productServices.TodaySpecial();
                if (productList != null)
                {
                    foreach (var item in productList.data)
                    {
                        if (item.name.Contains(tbSearch.Text))
                        {
                            listSearch.Add(item);
                        }
                    }
                    // đổ dữ liệu lấy dc vào giao diện
                    ProductList.ItemsSource = listSearch;
                }
            
        }

        private async void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string select = e.AddedItems[0].ToString();
            if (select.Equals("SortByName"))
            {
                ProductList productList = await _productServices.TodaySpecial();
                var ProductSortByPrice = productList.data.OrderBy(P => P.name);
                ProductList.ItemsSource = ProductSortByPrice;
            }
            else
            {
                ProductList productList = await _productServices.TodaySpecial();
                var ProductSortByPrice = productList.data.OrderBy(P => P.price);
                ProductList.ItemsSource = ProductSortByPrice;
            }
        }
    }
}
