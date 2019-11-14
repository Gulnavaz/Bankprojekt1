using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace Bankprojekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {

            this.InitializeComponent();
            NavigationDetail.Navigate(typeof(Startsida));

            string appName = Windows.ApplicationModel.Package.Current.DisplayName;
            BankLogic runtime = new BankLogic();
           
           
        }

        private void hamburger_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen; 
        }

        private void Startsida_Tapped(object sender, TappedRoutedEventArgs e)
        {
            NavigationDetail.Navigate(typeof(Startsida));
            MySplitView.IsPaneOpen = false;
        }

        private void Registrera_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            NavigationDetail.Navigate(typeof(Registrera)); 
            MySplitView.IsPaneOpen = false;
        }
        public void iconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Redigera_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            NavigationDetail.Navigate(typeof(Redigera));
            MySplitView.IsPaneOpen = false;
        }

        private void TextBlock_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            NavigationDetail.Navigate(typeof(Redigera));
            MySplitView.IsPaneOpen = false;
        }
    }
}
