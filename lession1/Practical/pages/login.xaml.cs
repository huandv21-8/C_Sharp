using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Practical.Services;
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

namespace Practical.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class login : Page
    {
        private service service;
        public login()
        {
            this.InitializeComponent();
        }

       
        private void Btn_Click_1(object sender, RoutedEventArgs e)
        {
            List<model.Users> users = service.getUser();

            foreach(model.Users user in users)
            {
                if (username.Text.Equals(user.username) && pass.Text.Equals(user.pass))
                {
                    mess.Text = "log in thanh cong";
                }
                else
                {
                    mess.Text = "username hoac pass sai!!!";
                }

            }

        }
    }
}
