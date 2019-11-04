using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankprojekt
{
    public class SavingsAccount
    {
        private decimal saldo;
        private double räntesats;
        private string kontotyp;
        private int accountId;

        public SavingsAccount(decimal saldo, double räntesats, string kontotyp, int accountId)
        {
            this.accountId = AccountId;
            this.räntesats = Räntesats;
            this.kontotyp = Kontotyp;
            this.saldo = Saldo;
        }
        public decimal Saldo { get; set; }
        public double Räntesats { get; set; }
        public string Kontotyp { get; set; }
        public int AccountId { get; set; }
    }
}
