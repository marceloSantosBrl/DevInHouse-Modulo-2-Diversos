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
    
    //[M2S02] Ex 2 - Par ou ímpar
    public static void EvenOrOdd()
    {
        var num = GetUserNumber("Digite um úmero");
        var message = num % 2 == 0 ? "even" : "odd";
        Console.WriteLine($"The number {num} is {message}");
    }

    // [M2S02] Ex 3 - Nome e Idade
    public static void ClassifyPatient()
    {
        var patientName = ReadInput("Digite o nome do paciente");
        var patientAge = GetUserNumber("Digite a idade do paciente");
        var patientClassification = patientAge switch
        {
            >= 0 and < 18 => "menor de idade",
            >= 18 and < 65 => "maior de idade",
            >= 65 => "idoso",
            _ => throw new ArgumentOutOfRangeException()
        };
        Console.WriteLine($"O paciente {patientName} é {patientClassification}");
    }

    // [M2S02] Ex 4 - Informações de veículos
    public static void ShowCarStatus()
    {
        var brand = ReadInput("Digite a marca do carro");
        var model = ReadInput("Digite o modelo do carro");
        var strMileage = ReadInput("Digite a quilometragem");
        if (!float.TryParse(strMileage,out var mileage))
        {
            Console.WriteLine("Valor inválido");
        }
        
        if (mileage < 0)
        {
            throw new ArgumentException();
        }
        
        Console.WriteLine($"O carro da marca {brand}, modelo {model}, rodour {mileage}KM");
        if (mileage > 10000)
        {
            Console.WriteLine("O carro precisa de revisão");
        }
    }

    // [M2S02] Ex 5 - Ordenando números
    public static void OrderNumbers()
    {
        var numberArray = new int[4];
        
        for (var i = 0; i < numberArray.Length; i += 1)
        {
            var currentNumber = GetUserNumber("Digite um número");
            numberArray[i] = currentNumber;
        }
        
        
        Console.WriteLine("#####");
        
        Array.Sort(numberArray);
        
        foreach (var i in numberArray)
        {
            Console.WriteLine(i);
        }
    }

    // [M2S02] Ex 6 - Separando palavras
    public static void GetLastWord()
    {
        var phrase = "A linguagem de programação C# é muito poderosa";
        var words = new List<string>(phrase.Split(' '));
        Console.WriteLine(words[^1]);
    }
    
    // [M2S02] Ex 7 - Números pares
    public static void ShowOdds()
    {
        int limit;
        do
        {
            limit = GetUserNumber("Digite um número");
            if (limit <= 0)
            {
                Console.WriteLine("Número inválido");
            }
        } while (limit <= 0);
        Console.WriteLine("####");
        
        for (var i = 0; i <= limit; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    // [M2S02] Ex 8 - O maior número da lista
    public static void GetGreatestNumber()
    {
        
        var numberArray = new int[5];
        var maxNumber = int.MinValue;
        
        for (var i = 0; i < numberArray.Length; i += 1)
        {
            var currentNumber = GetUserNumber("Digite um número");
            numberArray[i] = currentNumber;
            
            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
            }
        }
        
        Console.WriteLine($"O maior número é {maxNumber}");
    }
    
    private static int GetUserNumber(string message)
    {

        var string1 = ReadInput(message);
        
        if (!int.TryParse(string1,out var num1))
        {
            throw new ArgumentException("Número inválido");
        }

        return num1;
    }

    private static string ReadInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine() ?? string.Empty;
    }
}