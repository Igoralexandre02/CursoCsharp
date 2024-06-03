using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a cotação do dólar: ");
            var cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o valor que irá comprar: ");
            var dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            var valorTotal = ConversorDeMoedas.Conversor(cotacao, dolar);
            Console.WriteLine("Valor a ser pago em reais: "+ valorTotal.ToString("F2", CultureInfo.InvariantCulture)); 
        }
    }
}
