namespace semana1;

public static class Answerer
{
    public static void NumberSum()
    {
        Console.WriteLine("Digite um número");
        
        var string1 = Console.ReadLine();
        
        if (!int.TryParse(string1,out var num1))
        {
            Console.WriteLine("Número inválido");
        }
        
        Console.WriteLine("Digite outro número");
        
        var string2 = Console.ReadLine();
        
        if (!int.TryParse(string2,out var num2))
        {
            Console.WriteLine("Número inválido");
        }
        
        var result = num1 + num2;
        Console.WriteLine(result);
    }
}