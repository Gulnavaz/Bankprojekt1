using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankprojekt
{
    public class BankLogic       
    {
        public decimal amount;
        public decimal balance;
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
            App.Customers.Add(new Customer {
                Name = name, 
                PNr = pNr
            });

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
        public int AddSavingsAccount(Customer test)
        {
            //Skapa ny tom customer
            Customer customer = new Customer();

            //Leta efter den kunden som ska ha nytt sparkonto
            foreach (var cust in App.Customers)
            {
                //Om kunden i listan motsvarar den vi skickar in (test)
                if(cust == test)
                {
                    //spara kunden vi hittade till vår "customer" som vi skapa ovan
                    customer = cust;
                }
            }

            //ta bort den kunden
            App.Customers.Remove(customer);

            //skapa ny savingsaccount
            SavingsAccount saveAccount = new SavingsAccount();

            //Lägg till saker i sparkontot
            saveAccount.AccountId = Convert.ToInt32(customer.PNr);
            saveAccount.Saldo = 500;
            saveAccount.Räntesats = Convert.ToDouble(saveAccount.Saldo * Convert.ToDecimal(0.1 / 100));
            saveAccount.Kontotyp = "sparkonto";

            customer.Accounts.Add(saveAccount);
            App.Customers.Add(customer);

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
        public bool Deposit(Customer cust, long pNr, int accountId, decimal amount)
        {

            if (amount > 0)
            { 
            
                List<SavingsAccount> accountlist = cust.Accounts;
                SavingsAccount SearchAccount = accountlist.FirstOrDefault(choosen => choosen.AccountId == accountId);

                SearchAccount.Saldo += amount;

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Withdraw(Customer cust, long pNr, int accountId, decimal amount)
        {
            //Gör ett uttag på konto med kontonnummer accountId som tillhör
            //kunden pNr, returnerar true om det gick bra annars false.

            if (amount <= balance)
            {
                List<SavingsAccount> accountlist = cust.Accounts;
                SavingsAccount searchAcc = accountlist.FirstOrDefault(chosen => chosen.AccountId == accountId);
                searchAcc.Saldo -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string CloseAccount(long pNr, int accountId)
        {
            //Stänger ett konto med kontonnummer accountId som tillhör kunden
            //pNr, presentation av kontots saldo samt ränta på pengarna ska genereras.
            return null;
        }

        //TODO 1, lista av kunder på meny
        // 2 Att man kan välha en kund och se kundens alla konto, 
        // lägga till konto eller redigera konto , withdraw eller deposit, Radera konto.

    }
}
