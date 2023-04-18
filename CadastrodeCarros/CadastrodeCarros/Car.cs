namespace CadastrodeCarros;

// [M2S03] Ex 5 - Crie a classe Carro
public struct Car
{
    public string Brand { get; }
    public string Model { get; }
    public string Plate { get; }
    public string Color { get; }
    public Owner Owner { get; }

    public Car(string brand, string model, string plate, string color, Owner owner)
    {
        this.Brand = brand;
        this.Model = model;
        this.Plate = plate;
        this.Color = color;
        this.Owner = owner;
    }
}