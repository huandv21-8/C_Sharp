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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace lession1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Letter letter = new Letter(email.Text, title.Text, content.Text);
            LV.Items.Add(letter);

            email.Text = " ";
            title.Text = " ";
            content.Text = " ";
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            email.Text = "huan dep rai";
           /* for (int i = 0; i < LV.SelectedItems.Count(); i++)
            {
                LV.Items.Remove(LV.SelectedItems[i]);
               
            }*/
            Console.WriteLine("chay vao day "+LV.SelectedItems);
            content.Text = " "+LV.SelectedItems[0];
        }
    }
}
