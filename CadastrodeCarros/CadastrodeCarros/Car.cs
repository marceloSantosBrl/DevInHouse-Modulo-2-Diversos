namespace CadastrodeCarros;

// [M2S03] Ex 5 - Crie a classe Carro
public struct Car
{
    private string Brand { get; }
    private string Model { get; }
    private string Plate { get; }
    private string Color { get; }
    private Owner Owner { get; }

    public Car(string brand, string model, string plate, string color, Owner owner)
    {
        this.Brand = brand;
        this.Model = model;
        this.Plate = plate;
        this.Color = color;
        this.Owner = owner;
    }
}