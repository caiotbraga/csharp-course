using System;
using System.Globalization;
using Exceptions_Ex.Entities;
using Exceptions_Ex.Entities.Exceptions;
namespace Exceptions_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number;
                string holder;
                double Balance, withdrawLimit;
                double withdraw;
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                holder = Console.ReadLine();
                Console.Write("Initial Balance: ");
                Balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, Balance, withdrawLimit);
                Console.WriteLine("-----------------------");
                Console.WriteLine(account);
                Console.Write("Enter the amount for withdraw: ");
                withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);
                Console.Write(account);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
