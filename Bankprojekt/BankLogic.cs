using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankprojekt
{
    class BankLogic
    {
        public List<string> GetCustomers()
        {
            //Returnerar en List<string> som innehåller en presentation av bankens
            //alla kunder(personnummer och namn)
        }
        public boolean AddCustomer(string name, long pNr)
        {
              //Skapar upp en ny kund med namnet name samt personnumer pNr,
        }
        public List<string> GetCustomer(long pNr)
        {
               //Returnerar en List<string> som innehåller informationen om kunden

        }
        public boolean ChangeCustomerName(String name, long pNr)
        {
            //Byter namn på kund med personnummer pNr till name, returnerar true
            //om namnet ändrades annars returnerar false(om kunden inte fanns).
        }
        public List<string> RemoveCustomer(long pNr)
        {
            //Tar bort kund med personnummer pNr ur banken
        }
        public int AddSavingsAccount(long pNr)
        {
            //Skapar ett konto till kund med personnummer pNr
        }
        public string GetAccount(long pNr, int accountId)
        {
            //Returnerar en String som innehåller presentation av kontot med
            //kontonnummer accountId som tillhör kunden pNr(kontonummer,
            //saldo, kontotyp, räntesats).
        }
        public boolean Deposit(long pNr, int accountId, decimal amount)
        {
            //Gör en insättning på konto med kontonnummer accountId som tillhör
            //kunden pNr, returnerar true om det gick bra annars false.
        }
        public boolean Withdraw(long pNr, int accountId, decimal amount)
        {
            //Gör ett uttag på konto med kontonnummer accountId som tillhör
            //kunden pNr, returnerar true om det gick bra annars false.
        }
        public string CloseAccount(long pNr, int accountId)
        {
            //Stänger ett konto med kontonnummer accountId som tillhör kunden
            //pNr, presentation av kontots saldo samt ränta på pengarna ska genereras.
        }


    }
}
