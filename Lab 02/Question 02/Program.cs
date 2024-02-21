using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{


    class bankAccount

    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public bankAccount (string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {

            Balance = Balance + amount;
            Console.WriteLine($"Deposit of {amount:C} Successful.Update Balance:{Balance:C}");


        }

    }
    internal class Program
    {
        static void Main()
        {
            // Instantiate an object of the BankAccount class
            bankAccount myAccount = new bankAccount("123456789", 1000.00m);

            // Display initial balance
            Console.WriteLine($"Initial Balance: {myAccount.Balance:C}");

            // Perform a deposit
            Console.Write("Enter the amount to deposit: ");
            decimal depositAmount;
            if (decimal.TryParse(Console.ReadLine(), out depositAmount))
            {
                myAccount.Deposit(depositAmount);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}