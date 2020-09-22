using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using lession1.model;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace lession1.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Assignment4_food_Items : Page
    {
        private readonly string stringUrl = String.Format("https://foodgroup.herokuapp.com/api/today-special");
        public Assignment4_food_Items()
        {
            this.InitializeComponent();
            GetMenu();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MenuItem menuItem = e.Parameter as MenuItem;
        }

        public async void GetMenu()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(stringUrl);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();

                Assignment4_foodList menu1 = JsonConvert.DeserializeObject<Assignment4_foodList>(stringContent);

                MN.ItemsSource = menu1.data;
            }
        }
    }
}
