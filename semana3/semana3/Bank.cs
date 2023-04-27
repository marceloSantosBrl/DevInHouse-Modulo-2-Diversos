namespace semana3;

public class Bank
{
    private decimal _balance;

    public void Deposit(int value)
    {
        _balance += value;
    }

    public void Withdrawal(int value)
    {
        if (value > _balance)
        {
            Console.WriteLine("Saldo insuficiente");
            return;
        }

        _balance -= value;
    }

    public override string ToString()
    {
        return $"O saldo do cliente é de: R$ {_balance}";
    }
}