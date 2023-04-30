namespace semana3.ex_ten;

public class BankAccountExTen
{
    private readonly IList<decimal> _transactions = new List<decimal>();
    public decimal Balance { get; private set; }

    public BankAccountExTen(decimal balance)
    {
        Balance = balance;
    }

    public void Deposit(decimal value)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(value)} menor ou igual a zero");
        }

        Balance += value;
        _transactions.Add(value);
    }

    public bool Withdrawal(decimal value)
    {
        if (value > Balance)
        {
            return false;
        }

        Balance -= value;
        _transactions.Add(-value);
        return true;
    }

    public IList<decimal> GetTransactions()
    {
        return new List<decimal>(_transactions);
    }
}