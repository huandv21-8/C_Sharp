using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Weather.Models;
using Weather.Pages;
using Weather.Service;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Weather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame contentFrame;
        Root data = new Root();
        public MainPage()
        {
            this.InitializeComponent();

        }


        private async void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            WeatherService services = new WeatherService();
            data = await services.GetData();
            contentFrame = MainFrame;
            MainFrame.Navigate(typeof(Home), data);
        }
    }
}