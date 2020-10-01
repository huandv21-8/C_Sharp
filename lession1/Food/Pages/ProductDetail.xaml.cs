using Food3.Adapters;
using Food3.Models;
using Food3.Services;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Food3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductDetail : Page
    {
        private FoodDetailService service = new FoodDetailService();
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
            
            FavoriteService.InsertProduct(Detail);
            MainPage.contentFrame.Navigate(typeof(LayoutFavorite));
        }

        

        private void btBack(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            if(TbQuantity.Text != "")
            {

            CartItem item = new CartItem(Detail.id, Detail.name, Detail.image, Detail.price, Convert.ToInt32(TbQuantity.Text));
            Carts cart = new Carts();
            cart.AddToCart(item);
            MainPage.contentFrame.Navigate(typeof(ShowCart));
            }

            #region 
            //if (TbQuantity.Text != "")
            //{
            //    //check xem đã tồn tại sản phẩm trong giỏ hàng chưa
            //    int soluong = 0;
            //    List<Cart> listSelected = AddCartService.getDataCart();
            //    foreach(var item in listSelected)
            //    {
            //        if(item.id == Detail.id)
            //        {
            //            soluong = item.Quantity +Convert.ToInt32(TbQuantity.Text);
            //            break;
            //        }
            //    }
            //    if (soluong !=0)
            //    {
            //        AddCartService.updateQuantity(Detail.id, soluong);
            //        MainPage.contentFrame.Navigate(typeof(ShowCart));
            //        return;
            //    }

            //    Cart c = new Cart(Detail.id, Detail.name, Detail.image, Detail.description, Detail.price, Convert.ToInt32(TbQuantity.Text));
            //    AddCartService.AddtoCart(c);
            //    TbQuantity.Text = "";
            //    MainPage.contentFrame.Navigate(typeof(ShowCart));
            //}

            #endregion

        }

        private void TbQuantity_BeforeTextChanging(TextBox sender, TextBoxBeforeTextChangingEventArgs args)
        {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        }
    }
}
