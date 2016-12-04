using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Wlcome to my bank!");
            var choice="-1";
            while (true)
            {
                Console.WriteLine("Please select from the list of choises");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Creat Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Have a great day!");
                        return;
                    case "1":
                        Console.Write("Email Address: ");
                        var emailAddress = Console.ReadLine();
                        var checkingAccount = new Account();
                        checkingAccount.EmailAddress = emailAddress;
                        checkingAccount.AccountType = TypeOfAccounts.Checking; checkingAccount.Deposit(1002.50M);
                        Console.WriteLine($"Account Number: {checkingAccount.AccountNumber}, Balance: {checkingAccount.Balance:C}");
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
