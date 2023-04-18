// See https://aka.ms/new-console-template for more information

namespace CadastroDeCarros
{
    internal class Program
    {
        private static CarList? _carList;
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
            var cars = new List<Car>() { firstCar, secondCar, thirdCar };
            _carList = new CarList(cars);
            RunSelector();
        }
        
        private static void RunSelector()
        {
            var isTerminated = false;

            while (!isTerminated)
            {
                Console.WriteLine("Digite uma opção para continuar:\n" +
                                  "1 - Cadastrar Carro\n" +
                                  "2 - Consultar Carros\n" +
                                  "3 - Sair");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        _carList!.RegisterCar();
                        break;
                    case "2":
                        _carList!.ShowCarList();
                        break;
                    case "3":
                        isTerminated = true;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }   
}
