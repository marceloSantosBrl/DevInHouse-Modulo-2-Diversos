namespace semana1;

internal enum Operation
{
    Exit = -1,
    Plus,
    Minus,
    Times,
    Division,
}

public static class Answerer
{
    // [M2S02] Ex 1 - Soma de números
    public static void NumberSum()
    {
        var num1 = GetUserInt("Digite um número");
        var num2 = GetUserInt("Digite outro número");
        
        var result = num1 + num2;
        Console.WriteLine(result);
    }
    
    //[M2S02] Ex 2 - Par ou ímpar
    public static void EvenOrOdd()
    {
        var num = GetUserInt("Digite um úmero");
        var message = num % 2 == 0 ? "even" : "odd";
        Console.WriteLine($"The number {num} is {message}");
    }

    // [M2S02] Ex 3 - Nome e Idade
    public static void ClassifyPatient()
    {
        var patientName = ReadInput("Digite o nome do paciente");
        var patientAge = GetUserInt("Digite a idade do paciente");
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
        var mileage = GetUserFloat("Digite a quilometragem");

        if (mileage < 0)
        {
            throw new ArgumentOutOfRangeException();
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
            var currentNumber = GetUserInt("Digite um número");
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
            limit = GetUserInt("Digite um número");
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
        
        var numberArray = new float[5];
        var maxNumber = float.MinValue;
        
        for (var i = 0; i < numberArray.Length; i += 1)
        {
            var currentNumber = GetUserFloat("Digite um número");
            numberArray[i] = currentNumber;
            
            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
            }
        }
        
        Console.WriteLine($"O maior número é {maxNumber}");
    }

    // [M2S02] Ex 9 - Média aritmética

    public static void GetMean()
    {
        var count = 0;
        float sum = 0;
        while (true)
        {
            var input = ReadInput("digite um número ou s para sair");
            
            if (input == "s")
            {
                break;
            }

            sum += float.Parse(input);

            count += 1;
        }

        if (count == 0)
        {
            Console.WriteLine("Nenhum número digitado!");
            return;
        }
        
        Console.WriteLine($"A média é igual a {sum / count}");
            
    }

    // [M2S02] Ex 10 - Calculadora
    public static void RunCalculator()
    {

        while (true)
        {
            var numberInput = GetUserInt("Escolha uma das seguintes operações:" +
                                         "\n0 - adição \n1 - subtração\n2 - multiplicação\n3 - divisão\n-1 - Sair");

            var chosenOperation = (Operation) numberInput;
            if (!Enum.IsDefined(typeof(Operation), chosenOperation))
            {
                throw new ArgumentOutOfRangeException();
            }
            if (chosenOperation == Operation.Exit)
            {
                break;
            }
            var firstNumber = GetUserFloat("Digite o primeiro número");
            var secondNumber = GetUserFloat("Digite o segundo número");
            Console.WriteLine("O Resultado da operação é:");
            ShowCalculationResult(chosenOperation, firstNumber, secondNumber);
        }
        
    }

    private static int GetUserInt(string message)
    {

        var string1 = ReadInput(message);
        return int.Parse(string1);
    }

    private static float GetUserFloat(string message)
    {
        var input = ReadInput(message);
        if (!float.TryParse(input, out var result))
        {
            Console.WriteLine("Valor inválido");
        }

        return result;
    }

    private static string ReadInput(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine() ?? string.Empty;
    }

    private static void CustomDivision(float first, float second)
    {
        var result = second == 0 ? 
            "Divisão por zero" : $"{first / second}";
        Console.WriteLine(result);
    }

    private static void ShowCalculationResult(Operation chosenOperation, float firstNumber, float secondNumber)
    {
        switch (chosenOperation)
        {
            case Operation.Plus:
                Console.WriteLine(firstNumber + secondNumber);
                break;
            case Operation.Minus:
                Console.WriteLine(firstNumber - secondNumber);
                break;
            case Operation.Times:
                Console.WriteLine(firstNumber * secondNumber);
                break;
            case Operation.Division:
                CustomDivision(firstNumber, secondNumber);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}