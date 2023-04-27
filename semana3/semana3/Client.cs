namespace semana3;

public sealed class Client
{
    private readonly string _name;
    private readonly string _cpf;

    public Client(string name, string cpf)
    {
        _name = name;
        _cpf = cpf;
    }

    public override string ToString()
    {
        return $"O nome do cliente é: {_name} e seu cpf é: {_cpf}";
    }
}