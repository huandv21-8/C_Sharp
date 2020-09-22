using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Newtonsoft.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using lession1.model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace lession1.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Assignment4_home : Page
    {
        private readonly string stringUrl = String.Format("https://foodgroup.herokuapp.com/api/menu");

        public Assignment4_home()
        {
            this.InitializeComponent();
            GetMenu();
        }

        public async void GetMenu()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(stringUrl);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();

                Assignment4_menu menu1 = JsonConvert.DeserializeObject<Assignment4_menu>(stringContent);
                
                MN.ItemsSource = menu1.data;
            }
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Assignment4_menuItem menuItem = MN.SelectedItem as Assignment4_menuItem;
            MainFrame.Navigate(typeof(Assignment4_food_Items),menuItem);
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Assignment4_food_Items));
        }
    }
}
