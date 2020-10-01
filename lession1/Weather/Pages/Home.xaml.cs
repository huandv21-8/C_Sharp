using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Weather.Models;
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

namespace Weather.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        private string time;
        public Home()
        {
            this.InitializeComponent();
        }
        private Root Detail
        {
            get;
            set;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Detail = e.Parameter as Root;
            Detail.weather[0].icon = "http://openweathermap.org/img/wn/" + Detail.weather[0].icon + "@2x.png";
            time = DateTime.Now.ToString();
            

        }
    }
}
