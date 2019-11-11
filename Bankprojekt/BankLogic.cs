using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankprojekt
{
    public class BankLogic
    {
        public List<Customer> customers = new List<Customer>();
        private static BankLogic instance = null;

        public static BankLogic Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new BankLogic();
                }
                return instance;
            }
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> cust = customers;
            return cust;
        }
        public bool AddCustomer(string name, long pNr)
        {
          
            customers.Add(new Customer(name, pNr, null));

          
                return true;
            
        }
        public List<string> GetCustomer(long pNr)
        {
            //Returnerar en List<string> som innehåller informationen om kunden
            return null;
        }
        public bool ChangeCustomerName(String name, long pNr)
        {
            //Byter namn på kund med personnummer pNr till name, returnerar true
            //om namnet ändrades annars returnerar false(om kunden inte fanns).
            return true;
        }
        public List<string> RemoveCustomer(long pNr)
        {
            //Tar bort kund med personnummer pNr ur banken
            return null;
        }
        public int AddSavingsAccount(long pNr)
        {
            //Skapar ett konto till kund med personnummer pNr
            return 0;
        }
        public string GetAccount(Customer cust, int accountId)
        {
            string acc = null;
            foreach (SavingsAccount ac in cust.Accounts)
            {
                if (accountId == ac.AccountId)
                {
                    acc = ac.AccountId + " " + ac.Saldo + "" + ac.Räntesats;
                    break;
                }
            }
            return acc;

        }
        public bool Deposit(Customer cust,long pNr, int accountId, decimal amount)
        {
            List<SavingsAccount> accountlist = cust.Accounts;
            SavingsAccount SearchAccount = accountlist.FirstOrDefault(choosen => choosen.AccountId == accountId);

            SearchAccount.Saldo += amount;

            return true;
        }
        public bool Withdraw(long pNr, int accountId, decimal amount)
        {
            //Gör ett uttag på konto med kontonnummer accountId som tillhör
            //kunden pNr, returnerar true om det gick bra annars false.
            return true;
        }
        public string CloseAccount(long pNr, int accountId)
        {
            //Stänger ett konto med kontonnummer accountId som tillhör kunden
            //pNr, presentation av kontots saldo samt ränta på pengarna ska genereras.
            return null;
        }


    }
}
