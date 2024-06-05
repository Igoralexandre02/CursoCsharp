using System.Globalization;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número da conta: ");
            var conta = int.Parse(Console.ReadLine());

            Console.Write("Informe o nome do titular: ");
            var nome = Console.ReadLine();

            var Titular = new ContaBancaria(conta, nome);

            Console.Write("Hávera deposito inicial [S/N]? ");
            var depositoInicial = Console.ReadLine();

            double valorDeposito;

            if (depositoInicial == "S")
            {
                Console.Write("Informe o valor do deposito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Titular.Deposito(valorDeposito);
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(Titular.ToString());
            Console.WriteLine("");

            Console.Write("Entre um valor para deposito: ");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Titular.Deposito(valorDeposito);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(Titular.ToString());
            Console.WriteLine("");

            Console.Write("Entre um valor para saque: ");
            var valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Titular.Saque(valorSaque);
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(Titular.ToString());
        }
    }
}
