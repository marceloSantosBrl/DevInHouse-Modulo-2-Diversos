namespace CadastrodeCarros;

// [M2S03] Ex 3 - Crie a classe Proprietario
public struct Owner
{
    private string Name { get; }
    private string Cpf { get; }
    private string Phone { get; }

    public Owner(string name, string cpf, string phone)
    {
        this.Name = name;
        this.Cpf = cpf;
        this.Phone = phone;
    }
}