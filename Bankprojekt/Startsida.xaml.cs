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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Bankprojekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Startsida : Page
    {
        public Startsida()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string Temp = "Kunder\t";
            for(int i = 0; i < BankLogic.Instance.customers.Count; i++)
            {
                Temp = Temp + BankLogic.Instance.customers[i].Name + " pNr: " + BankLogic.Instance.customers[i].PNr.ToString() + "\t";
            }
            Lista.Text = Temp;
        }
    }
}
