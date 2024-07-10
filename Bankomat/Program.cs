using System;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 1000.00m; 
            int option;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Bankomat");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CheckBalance(balance);
                        break;
                    case 2:
                        balance = DepositMoney(balance);
                        break;
                    case 3:
                        balance = WithdrawMoney(balance);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the Bankomat. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (option != 4)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

            } while (option != 4);
        }

        static void CheckBalance(decimal balance)
        {
            Console.WriteLine($"Your current balance is: {balance:C}");
        }

        static decimal DepositMoney(decimal balance)
        {
            Console.Write("Enter the amount to deposit: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            if (depositAmount > 0)
            {
                balance += depositAmount;
                Console.WriteLine($"You have successfully deposited {depositAmount:C}. Your new balance is {balance:C}.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }

            return balance;
        }

        static decimal WithdrawMoney(decimal balance)
        {
            Console.Write("Enter the amount to withdraw: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            if (withdrawAmount > 0 && withdrawAmount <= balance)
            {
                balance -= withdrawAmount;
                Console.WriteLine($"You have successfully withdrawn {withdrawAmount:C}. Your new balance is {balance:C}.");
            }
            else if (withdrawAmount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }

            return balance;
        }
    }
}
