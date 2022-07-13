using System;

namespace POO_ExESPECIAL {
    internal class Program {
        static void Main(string[] args) {

            int account;
            string name;
            char depositMoney;
            double money;

            BankAccount bankAccount;

            Console.WriteLine("Insert the account number:");
            account = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert the account owner:");
            name = Console.ReadLine();
            Console.WriteLine("Will there be an initial deposit? (s/n)");
            depositMoney = char.Parse(Console.ReadLine());
            while(depositMoney != 's' && depositMoney != 'n') {
                Console.WriteLine("Will there be an initial deposit? (s/n)");
                depositMoney = char.Parse(Console.ReadLine());
            }
            if (depositMoney == 's' || depositMoney == 'S') {
                Console.WriteLine("How much is your deposit?");
                money = double.Parse(Console.ReadLine());
                bankAccount = new BankAccount(account, name, money);
            }
            else {
                bankAccount = new BankAccount(account, name);
            }

            Console.WriteLine(bankAccount);
            Console.WriteLine("Insert a vallue to deposit money:");
            money = double.Parse(Console.ReadLine());
            bankAccount.Deposit(money);
            Console.WriteLine("Bank account updated:" + bankAccount);
            Console.WriteLine("Insert a vallue to withdraw money:");
            money = double.Parse(Console.ReadLine());
            bankAccount.WithdrawMoney(money);
            Console.WriteLine("Bank account updated:");
            Console.WriteLine(bankAccount);
        }
    }
}
