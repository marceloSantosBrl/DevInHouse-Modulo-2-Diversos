// See https://aka.ms/new-console-template for more information

namespace semana3;

internal class Semana3
{
    public static void Main(string[] args)
    {
        var person = new Person("Marcelo", 20, "Praça da Natureza");
        person.Salute();
        var bankAccount = new BankAccount(1233345);
        bankAccount.Deposit(20);
        bankAccount.Withdrawal(10);
        Console.WriteLine(bankAccount.Balance);
    }
}