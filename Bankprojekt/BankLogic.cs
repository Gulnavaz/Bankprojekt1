using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankprojekt
{
    public class BankLogic
    {
         static List<Customer> customers = new List<Customer>();
         public static List<SavingsAccount> accounts = new List<SavingsAccount>();


        public List<Customer> GetCustomers()
        {
            List<Customer> cust = customers;
            return cust;
        }
        public bool AddCustomer(string name, long pNr)
        {
            Customer Nycustomer = new Customer(name, pNr, accounts);
            customers.Add(Nycustomer);

            if (Nycustomer.PNr == pNr)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<string> GetCustomer(long pNr)
        {
            //Returnerar en List<string> som innehåller informationen om kunden
            return;
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
        }
        public int AddSavingsAccount(long pNr)
        {
            //Skapar ett konto till kund med personnummer pNr
            return 0;
        }
        public string GetAccount(Customer cust, int accountId)
        {
            string acc = null;
            foreach (SavingsAccount ac in cust.CustomerList)
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
            List<SavingsAccount> accountlist = cust.CustomerList;
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
            return;
        }


    }
}
