using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankprojekt
{
    public class Customer
    {
        private string name;
        private long pNr;
        

        private List<SavingsAccount> customerList;

        public Customer(string name, long pNr, List<SavingsAccount> accounts)
        {
            this.name = Name;
            this.pNr = PNr;
            customerList = accounts;
        }
        public string Name { get; set; }
        public long PNr { get; set; }
        public List<SavingsAccount> CustomerList { get; set; }

    }
}
