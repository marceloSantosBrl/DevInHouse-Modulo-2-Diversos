// See https://aka.ms/new-console-template for more information

using CadastrodeCarros;

namespace CadastrodeCarros
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // [M2S03] Ex 4 - Crie Instâncias para a classe Proprietario
            var firstOwner = new Owner("Marcelo", "84578942536", "67984447856");
            var secondOwner = new Owner("Andre", "45678997745", "488782245889");
            var thirdOwner = new Owner("Silva", "455477811788", "445858844565");
            // [M2S03] Ex 6 - Crie Instâncias para a classe carro
            var firstCar = new Car("toyota", "corolla", "kjs887", "blue",firstOwner);
            var secondCar = new Car("honda", "civic", "tss298", "red", secondOwner);
            var thirdCar = new Car("fiat", "toro", "ghj774", "grey", thirdOwner);
            
            // [M2S03] Ex 7 - Crie uma variável do tipo lista de carro, para armazenar as Instâncias de carro
            List<Car> carList = new () { firstCar, secondCar, thirdCar };
        }
    }   
}
