using Exceptions_Ex.Entities.Exceptions;
using System.Text;
using System.Globalization;
namespace Exceptions_Ex.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(Balance < amount)
            {
                throw new DomainExceptions("Error! Not enough balance!");
            }
            if(amount > WithdrawLimit)
            {
                throw new DomainExceptions("Error! Your limit of withdraw is " + WithdrawLimit);
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Accout data:");
            sb.AppendLine("Number: " + Number);
            sb.AppendLine("Holder: " + Holder);
            sb.AppendLine("Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
            sb.AppendLine("Withdraw Limit: " + WithdrawLimit.ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
