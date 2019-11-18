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
    public sealed partial class Redigera : Page
    {
        public Customer Selected { get; set; }
        public Redigera()
        {
            this.InitializeComponent();
            App.Customers.Add(new Customer() { Name = "Björn Johansson", PNr = 8912022738 });
            App.Customers.Add(new Customer() { Name = "Fredrik Karlsson", PNr = 9202131242 });
            App.Customers.Add(new Customer() { Name = "Amanda Andersson", PNr = 9412038234 });
            App.Customers.Add(new Customer() { Name = "Alexander Johansson", PNr = 8205021523 });
            App.Customers.Add(new Customer() { Name = "Alex Larsen", PNr = 6305151526 });
            App.Customers.Add(new Customer() { Name = "Anders Larsson", PNr = 6908172592 });
            App.Customers.Add(new Customer() { Name = "Anders Ohlsen", PNr = 7811022849 });
            App.Customers.Add(new Customer() { Name = "Pontus Fyhrberg", PNr = 7412199572 });

            CustomersListView.ItemsSource = App.Customers.OrderBy(x => x.Name);
            //CustomersAccountListView.ItemsSource = Selected.Accounts;
        }

        private void SelectCustomer_Click(object sender, ItemClickEventArgs e)
        {
            var selectedCustomer = (Customer)e.ClickedItem;
            Selected = selectedCustomer;

            SelectedPersonPnr.Text = Selected.PNr.ToString();
            SelectedPersonName.Text = Selected.Name;
            SelectedPersonNameEdit.Text = Selected.Name;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if(SelectedPersonNameEdit.Visibility == Visibility.Visible)
            {
                SelectedPersonName.Visibility = Visibility.Visible;
                SelectedPersonNameEdit.Visibility = Visibility.Collapsed;
                btnEdit.Content = "Redigera";
                
                App.Customers.Remove(Selected);

                Selected.Name = SelectedPersonNameEdit.Text;
                App.Customers.Add(Selected);
                CustomersListView.ItemsSource = App.Customers.OrderBy(x => x.Name);

                SelectedPersonPnr.Text = Selected.PNr.ToString();
                SelectedPersonName.Text = Selected.Name;
                SelectedPersonNameEdit.Text = Selected.Name;
            }
            else if (!(SelectedPersonNameEdit.Visibility == Visibility.Visible))
            {
                SelectedPersonName.Visibility = Visibility.Collapsed;
                SelectedPersonNameEdit.Visibility = Visibility.Visible;
                btnEdit.Content = "Spara";

            }
        }

        private void btnMoney_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void addAccount_Click_1(object sender, RoutedEventArgs e)
        {
            BankLogic.Instance.AddSavingsAccount(Selected);
        }
    }
}
