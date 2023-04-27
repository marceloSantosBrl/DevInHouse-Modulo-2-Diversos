// See https://aka.ms/new-console-template for more information

namespace semana3;

internal class Semana3
{
    public static void Main(string[] args)
    {
        var client = new Client("marcelo", "85444888699");
        var bankAccount = new ComplexBankAccount("87978", client);
        bankAccount.Deposit(800);
        bankAccount.Withdrawal(100);
        bankAccount.ShowData();
    }
}