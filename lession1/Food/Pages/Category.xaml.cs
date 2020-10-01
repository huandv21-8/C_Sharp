using Food3.Models;
using Food3.Services;
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

namespace Food3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Category : Page
    {
        private CategoryService _categoryService = new CategoryService();
        public Category()
        {
            this.InitializeComponent();
        }
        private MenuItem CatDetail { get; set; }

        protected async override void OnNavigatedTo(NavigationEventArgs e)// ham nhan menuItem ben mainPage gửi sang
        {
            MenuItem menuItem = e.Parameter as MenuItem;
            CatDetail = menuItem;
            ButtonBack.IsEnabled = this.Frame.CanGoBack;
            Models.CategoryDetail catDetail = await _categoryService.CategoryDetail(CatDetail.id);
            ProductList.ItemsSource = catDetail.data.foods;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }
       
        private void GridViewItem_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            //click vao san pham=> chi tiet san pham
            Product product = ProductList.SelectedItem as Product;
            MainPage.contentFrame.Navigate(typeof(ProductDetail), product);

        }

        private async void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

            string select = e.AddedItems[0].ToString();
            if (select.Equals("SortByName"))
            {
                Models.CategoryDetail catDetail = await _categoryService.CategoryDetail(CatDetail.id);
                ProductList.ItemsSource = catDetail.data.foods.OrderBy(P => P.name);
               
            }
            else
            {
                Models.CategoryDetail catDetail = await _categoryService.CategoryDetail(CatDetail.id);
                ProductList.ItemsSource = catDetail.data.foods.OrderBy(P => P.price);
            }
        }

        private async void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Product> listSearch = new List<Product>();
            Models.CategoryDetail catDetail = await _categoryService.CategoryDetail(CatDetail.id);
            var list = catDetail.data.foods;
            if (list != null)
            {
                foreach (var item in list)
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
}
