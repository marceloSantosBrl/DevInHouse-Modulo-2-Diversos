
namespace semana3;

public class Person
{
    private string _name;
    protected int Age;
    public string Address { get; set; }

    public Person(string name, int age, string address)
    {
        _name = name;
        this.Age = age;
        this.Address = address;
    }

    public void Salute()
    {
        Console.WriteLine($"Olá, meu nome é {_name} e eu tenho {Age} anos");
    }
}