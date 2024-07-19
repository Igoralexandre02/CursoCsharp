using CursoCsharp.Exceptions;
using System.Globalization;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                var number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                var holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                var balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                var withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Account account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                var amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.WriteLine();

                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(AccountExcepiton a)
            {
                Console.WriteLine("Widhtdraw Erro: " + a.Message);
            }           
        }
    }
}