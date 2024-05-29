using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var R = new Retangulo();

            Console.WriteLine("Entre com os valores de altura e largura:");
            Console.Write("Largura: ");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + R.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + R.Perimentro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
