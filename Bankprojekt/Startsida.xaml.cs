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
            App.Customers.Add(new Customer() { Name = "Björn Johansson", PNr = 8912022738 });
            App.Customers.Add(new Customer() { Name = "Fredrik Karlsson", PNr = 9202131242 });
            App.Customers.Add(new Customer() { Name = "Amanda Andersson", PNr = 9412038234 });
            App.Customers.Add(new Customer() { Name = "Alexander Johansson", PNr = 8205021523 });
            App.Customers.Add(new Customer() { Name = "Alex Larsen", PNr = 6305151526 });
            App.Customers.Add(new Customer() { Name = "Anders Larsson", PNr = 6908172592 });
            App.Customers.Add(new Customer() { Name = "Anders Ohlsen", PNr = 7811022849 });
            App.Customers.Add(new Customer() { Name = "Pontus Fyhrberg", PNr = 7412199572 });

            CustomersListView.ItemsSource = App.Customers.OrderBy(x => x.Name);
            
        }
    }
}
