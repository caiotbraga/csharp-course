using System;
namespace POO_ExESPECIAL {
    internal class BankAccount {

        private string _name;
        public int Account { get; private set; }
        public double DepositMoney { get; set; }

        public BankAccount() {
        }
        public BankAccount(int account, string name, double depositMoney) {
            Account = account;
            _name = name;
            DepositMoney = depositMoney;
        }
        public BankAccount(int account, string name) {
            Account = account;
            _name = name;
            DepositMoney = 0;
        }

        public string Name {
            get { return _name; }
            set {
                if (value != null && value.Length > 1) {
                    _name = value;
                }
            }
        }

        public double Deposit(double money) {
            return DepositMoney += money;
        }

        public double WithdrawMoney(double money) {
            return DepositMoney = DepositMoney - money - 5;
        }

        override public string ToString() {
            return "Account:" + Account + ", Account owner:" + _name + ", balance: $" + DepositMoney;
        }
    }
}
