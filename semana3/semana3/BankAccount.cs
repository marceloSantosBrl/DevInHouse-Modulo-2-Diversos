namespace semana3;

public sealed class BankAccount
{
    private int _accountNumber;
    public decimal Balance { get; private set; } = 0;

    public BankAccount( int accountNumber)
    {
        _accountNumber = accountNumber;
    }

    public void Deposit(decimal value)
    {
        Balance += value;
    }

    public void Withdrawal(decimal value)
    {
        if (value > Balance)
        {
            Console.WriteLine("Voce Não tem fundos suficientes");
            return;
        }

        Balance -= value;
    }
}