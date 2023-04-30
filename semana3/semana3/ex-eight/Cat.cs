namespace semana3.ex_eight;

public class Cat: Animal
{
    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public sealed override string Name { get; set; }
    public sealed override int Age { get; set; }
    public override void ShowSound()
    {
        Console.WriteLine("Miau!");
    }
}