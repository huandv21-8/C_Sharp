using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using lession1.model;
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
    public sealed partial class AddPhone : Page

    {

        public AddPhone()
        {
            this.InitializeComponent();
     
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string type = ((ComboBoxItem)cbTypeContact.SelectedItem).Content.ToString();
            string icon = "";
            if (type == "Love")
            {
                icon = "EB51";
            }
            else if (type == "Person")
            {
                icon = "E80F";
            }
            else if (type == "Work")
            {
                icon = "E821";
            }
            Phone db = new Phone( (char)(Convert.ToInt32(icon, 16)),txtName.Text, txtTel.Text, type);
            ViewModels.viewModels.listPhone.Add(db);
            PhoneBook.contentFrame.Navigate(typeof(ListPhonexaml));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PhoneBook.contentFrame.Navigate(typeof(ListPhonexaml));   
        }
    }
}
