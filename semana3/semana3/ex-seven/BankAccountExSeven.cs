namespace semana3.ex_seven;

public class BankAccountExSeven
{
    public const decimal MaxBalance = 10000;
    public decimal Balance { get; set; }

    public void Deposit(decimal value)
    {
        var updatedBalance = value + Balance;
        if ( value <= 0 || updatedBalance > MaxBalance)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Valor inválido");
        }

        Balance = updatedBalance;
    }

    public void Withdrawal(decimal value)
    {
        if (value > Balance)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Valor inválido");
        }
        Balance -= value;
    }
}