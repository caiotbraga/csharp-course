using System;
using System.Globalization;
namespace POO_ExESPECIAL {
    internal class BankAccount {

        private string _name;
        public int Account { get; private set; }
        public double DepositMoney { get; private set; }

        public BankAccount() {
        }
        public BankAccount(int account, string name) {
            Account = account;
            _name = name;
            DepositMoney = 0;
        }

        public BankAccount(int account, string name, double depositMoney) : this(account, name) {
            Deposit(depositMoney);
        }

        public string Name {
            get { return _name; }
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }

        public void Deposit(double money) {
            DepositMoney += money;
        }

        public void WithdrawMoney(double money) {
             DepositMoney -= money;
            DepositMoney -= 5.0; //tax
        }

        override public string ToString() {
            return "Account:" + Account +
                ", Account owner:" + _name + 
                ", balance: $" + DepositMoney.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
