namespace semana1;

public static class Answerer
{
    // [M2S02] Ex 1 - Soma de números
    public static void NumberSum()
    {
        var num1 = GetUserNumber("Digite um número");
        var num2 = GetUserNumber("Digite outro número");
        
        var result = num1 + num2;
        Console.WriteLine(result);
    }

    public static void EvenOrOdd()
    {
        var num = GetUserNumber("Digite um úmero");
        var message = num % 2 == 0 ? "even" : "odd";
        Console.WriteLine($"The number {num} is {message}");
    }

    private static int GetUserNumber(string message)
    {
        Console.WriteLine(message);
        
        var string1 = Console.ReadLine();
        
        if (!int.TryParse(string1,out var num1))
        {
            Console.WriteLine("Número inválido");
        }

        return num1;
    }
    
}