﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankprojekt
{
    
    public class SavingsAccount
    {
        public static int accountNumberTracker = 1000;
        public SavingsAccount()
        {
            Kontotyp = "";
            AccountId = accountNumberTracker;
            accountNumberTracker++;
        }

        public decimal Saldo { get; set; }
        public double Räntesats { get; set; }
        public string Kontotyp { get; set; }
        public int AccountId { get; set; }
    }   

}

