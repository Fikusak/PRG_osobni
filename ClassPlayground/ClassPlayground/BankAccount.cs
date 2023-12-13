using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class BankAccount
    {
        public int accountNumber;
        public string holderName;
        public string currency;
        public int balance;
        public BankAccount(int accountNumber, string holderName, string currency, int balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.currency = currency;
            this.balance = balance;
        }
        public void Exchange()
        {

        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine(balance + "Kč");
        }

        public void Withdraw(int take)
        {
            balance = balance - take;
            if(balance < 0)
            {
                Console.WriteLine("Nedostatek peněz na účtu");
            }
        }

        public void Transfer(int amount, int accountNumber)
        {
            BankAccount bankAcount1 = new BankAccount(1111, "Rastislav", "Euro", 1000);
            BankAccount BankAcount2 = new BankAccount(2222, "Bohumír", "Koruna", 53);
            if(bankAcount1.currency == "Euro")
            {
                bankAcount1.balance = bankAcount1.balance * 25;
            }
            bankAcount1.balance = bankAcount1.balance - amount;
            if (bankAcount1.balance < 0) 
            {
                Console.WriteLine("Jsi chudý");
            }
            BankAcount2.balance = BankAcount2.balance + amount;
            Console.WriteLine("Zůstatek na vašem účtu " + bankAcount1.balance + " zůstatek na cizím účtu " + BankAcount2.balance);
        }


    }
}
