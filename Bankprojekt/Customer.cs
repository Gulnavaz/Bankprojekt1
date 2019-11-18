using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankprojekt
{
    public class Customer
    {
        public static int accountNumberTracker = 1000;
        public Customer()
        {
            Saldo = 500;
            AccountId = accountNumberTracker;
            accountNumberTracker++;
            Accounts = new List<SavingsAccount>();
        }
        public string Name { get; set; }
        public long PNr { get; set; }
        public List<SavingsAccount> Accounts { get; set; }

        public int AccountId { get; set; }
        public decimal Saldo { get; set; }
    }
}
