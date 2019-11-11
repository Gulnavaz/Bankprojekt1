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

            string appName = Windows.ApplicationModel.Package.Current.DisplayName;
            
           // NavigationView.MenuItemsSourceProperty =
        }

        private void hamburger_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen; 
        }

        private void iconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (start.IsSelected) { ResultTextBlock.Text = "Startsida"; }
            else if (register.IsSelected) {ResultTextBlock.Text="Registrera"; }
            else if (edit.IsSelected) { ResultTextBlock.Text = "Redigera"; }
        }

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
