using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using lession1.model;
using Windows.ApplicationModel.Contacts;
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
    public sealed partial class PhoneBook : Page
    {
        public static Frame contentFrame;
        public PhoneBook()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SV.IsPaneOpen = !SV.IsPaneOpen;
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E80F", 16)), "Home","home"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("EA4A", 16)), "Contact","contact"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E716", 16)), "Customer", "customer"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E715", 16)), "Email", "email"));
        }

        private void LV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)LV.SelectedItem;
            if (selected.Dest.Equals("home"))
            {
                FrContent.Navigate(typeof(ListPhonexaml));
            }
            else if (selected.Dest.Equals("contact"))
            {
                FrContent.Navigate(typeof(AddPhone));
            }
          

        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            contentFrame = FrContent;
            FrContent.Navigate(typeof(ListPhonexaml));
        }
    }
}
