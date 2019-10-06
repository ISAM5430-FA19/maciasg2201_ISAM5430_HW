using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", 7.53m);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

            /*
            Console.Write("\nEnter depot amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account1 balance\n");
            account1.Deposit(depositAmount);
            
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

            Console.Write("\nEnter depot amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
            account2.Deposit(depositAmount);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
            */

            Console.Write("\nEnter withdraw amount for account1: ");
            decimal iWithdrawAmount = decimal.Parse(Console.ReadLine());
            account1.Withdraw(iWithdrawAmount);

            Console.Write("\nEnter withdraw amount for account2: ");
            iWithdrawAmount = decimal.Parse(Console.ReadLine());
            account2.Withdraw(iWithdrawAmount);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
        }
    }
}
