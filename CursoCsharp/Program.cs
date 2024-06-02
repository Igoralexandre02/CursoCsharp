using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var F1 = new Funcionario();

            Console.Write("Nome: ");
            F1.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            F1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");
            Console.WriteLine("Funcionario: " + F1.Nome + ", Salario Liquido: $" + F1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
            Console.Write("Digite o valor da porcentagem: ");
            var porcentagem = double.Parse(Console.ReadLine());
            F1.AumentarSalario(porcentagem);
            Console.WriteLine("");
            Console.WriteLine("Dados Atualizados: " + F1.Nome + ", Salario Liquido: $" + F1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            //var R = new Retangulo();

            //Console.WriteLine("Entre com os valores de altura e largura:");
            //Console.Write("Largura: ");
            //R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Altura: ");
            //R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("AREA: " + R.Area().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("PERIMETRO: " + R.Perimentro().ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("DIAGONAL: " + R.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
