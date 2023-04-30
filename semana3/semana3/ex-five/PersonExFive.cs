namespace semana3.ex_five;

public class PersonExFive
{
    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(Age), "Idade inválida");
            }

            _age = value;
        }
    }

    private string _name;

    public PersonExFive(int age, string name)
    {
        if (age < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(age), "Idade inválida");
        }
        _age = age;
        _name = name;
    }
}