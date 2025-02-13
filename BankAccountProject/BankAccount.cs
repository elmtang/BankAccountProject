public class BankAccount
{
    private string accountHolder;
    private decimal balance;

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

}
