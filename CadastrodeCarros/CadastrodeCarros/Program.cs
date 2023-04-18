// See https://aka.ms/new-console-template for more information

using CadastrodeCarros;

namespace CadastrodeCarros
{
    internal class Program
    {
        // [M2S03] Ex 4 - Crie Instâncias para a classe Proprietario
        public static void Main(string[] args)
        {
            var firstOwner = new Owner("Marcelo", "84578942536", "67984447856");
            var secondOwner = new Owner("Andre", "45678997745", "488782245889");
            var thirdOwner = new Owner("Silva", "455477811788", "445858844565");
        }
    }   
}
