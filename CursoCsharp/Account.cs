using CursoCsharp.Exceptions;

namespace CursoCsharp
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
            Balance = amount;
        }
        public void Withdraw(double amount)
        {
            if (WithdrawLimit == 0 || WithdrawLimit < amount )
            {
                throw new AccountExcepiton("The amount exceeds withdraw limit");
            }
            else if(Balance < amount)
            {
                throw new AccountExcepiton("Not enough balance");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}
