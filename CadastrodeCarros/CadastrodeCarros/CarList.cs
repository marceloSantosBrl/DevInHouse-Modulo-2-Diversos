namespace CadastroDeCarros;

public class CarList
{
    // [M2S03] Ex 7 - Crie uma variável do tipo lista de carro, para armazenar as Instâncias de carro
    public CarList(List<Car> cars)
    {
        Cars = cars;
    }

    private List<Car> Cars { get;  }
    
    // [M2S03] Ex 8 - Crie um método para Cadastrar novos Carros na lista

    public void RegisterCar()
    {
        var newCar = MakeCar();
        Cars.Add(newCar);
    }


    public static string ReadConsole(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine() ?? "";
    }

    private static Owner MakeOwner()
    {
        var name = ReadConsole("Digite o nome");
        var cpf = ReadConsole("Digite o CPF");
        var phone = ReadConsole("Digite o telefone");
        return new Owner(name, cpf, phone);
    }

    private static Car MakeCar()
    {
        var brand = ReadConsole("Digite a marca");
        var model = ReadConsole("Digite o modelo");
        var plate = ReadConsole("Digite a placa");
        var color = ReadConsole("Digite a cor");
        var owner = MakeOwner();
        return new Car(brand, model, plate, color, owner);
    }

    private static void ShowOwner(Owner owner)
    {
        Console.WriteLine("");
        Console.WriteLine(owner.Name);
        Console.WriteLine(owner.Cpf);
        Console.WriteLine(owner.Phone);
    }

    private static void ShowCar(Car car)
    {
        Console.WriteLine(car.Brand);
        Console.WriteLine(car.Model);
        Console.WriteLine(car.Plate);
        Console.WriteLine(car.Color);
        ShowOwner(car.Owner);
        Console.WriteLine("#######");
    }

    // [M2S03] Ex 9 - Crie um método para exibir a lista de carros e seus respectivos proprietários
    public void ShowCarList()
    {
        foreach (var car in Cars)
        {
            ShowCar(car);
        }
    }
}
