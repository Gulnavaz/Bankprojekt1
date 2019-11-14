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
    public sealed partial class Registrera : Page
    {
        public Registrera()
        {
            this.InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)//Namn
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)//prnummer
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)//lägg till
        {
            try
            {
                if (App.Customers.Where(c => c.PNr == Convert.ToInt64(pNr.Text)).ToList().Count > 0) 
                {
                    kundText.Text = "Kunden finns redan";
                }
                else
                {
                    BankLogic.Instance.AddCustomer(Namn.Text, Convert.ToInt64(pNr.Text));
                    kundText.Text = "Kunden är tillagd";
                }
            }
            catch(Exception ex)
            {
                kundText.Text = ex.Message;
            }

        }
    }
}
