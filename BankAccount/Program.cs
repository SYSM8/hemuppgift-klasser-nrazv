using System.Globalization;

namespace BankAccount;

internal class Program
{
    static void Main(string[] args)
    {
        BankAccount bankAccount = new(AccountNumber: "83651926532", AccountHolder: "Jacob Peterson");
        bankAccount.Deposit(100.0);
        bankAccount.ShowBalance();
        bankAccount.Withdraw(10.0);
        bankAccount.ShowBalance();
        bankAccount.Withdraw(1000.0);
    }


}
