
namespace BankAccount
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { set; get; }
        private double _balance = 0.0;

        public BankAccount(string AccountNumber, string AccountHolder)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;

        }

        public void ShowBalance()
        {
            WriteLine($"Current Balance: {_balance}");
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            WriteLine($"Deposited: {amount} - Current Balance: {_balance}");
        }

        public void Withdraw(double amount)
        {
            if (_balance < amount)
            {
                WriteLine($"Insufficient funds !");
                return;
            }

            _balance -= amount;
            WriteLine($"Withdrew: {amount} - Current Balance: {_balance}");

        }
    }
}
