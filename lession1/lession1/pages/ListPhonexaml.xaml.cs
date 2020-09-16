using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using lession1.model;
using lession1.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using lession1.ViewModels;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace lession1.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListPhonexaml : Page
    {
        public ListPhonexaml()
        {
            this.InitializeComponent();
            GV.ItemsSource = ViewModels.viewModels.listPhone;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PhoneBook.contentFrame.Navigate(typeof(AddPhone));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Phone x = (Phone)GV.SelectedItem;
            /*  viewModels.listPhone.Remove(x);*/
            ViewModels.viewModels.listPhone.Remove(x);
            PhoneBook.contentFrame.Navigate(typeof(ListPhonexaml));



        }
    }
}
