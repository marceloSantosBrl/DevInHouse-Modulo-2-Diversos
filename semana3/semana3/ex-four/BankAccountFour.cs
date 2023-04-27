namespace semana3.ex_four;

public class BankAccountFour
{
    private decimal _balance;

    public void Deposit(decimal value)
    {
        _balance += value;
    }

    public bool Withdrawal(decimal value)
    {
        if (value > _balance)
        {
            return false;
        }

        _balance -= value;
        return true;
    }
}