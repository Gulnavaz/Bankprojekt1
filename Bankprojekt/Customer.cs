using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankprojekt
{
    public class Customer
    {

        public Customer()
        {
            //this.Name = Name;
            //this.PNr = PNr;
            //this.Accounts = accounts; 
            Accounts = new List<SavingsAccount>();
        }
        public string Name { get; set; }
        public long PNr { get; set; }
        public List<SavingsAccount> Accounts { get; set; }
        

    }
}
