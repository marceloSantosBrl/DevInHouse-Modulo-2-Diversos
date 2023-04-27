namespace semana3;

public class ComplexBankAccount : Bank
{
    private string _number;
    private Client _client;

    public ComplexBankAccount(string number, Client client)
    {
        _number = number;
        _client = client;
    }

    public void ShowData()
    {
        Console.WriteLine(_client);
        Console.WriteLine($"O número da conta bancária do cliente é {_number}");
        Console.WriteLine(base.ToString());
    }
}