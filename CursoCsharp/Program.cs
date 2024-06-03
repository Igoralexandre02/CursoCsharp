using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A1 = new Aluno();
            Console.Write("Nome do aluno: ");
            A1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            A1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (A1.NotaTotal() >= 60.00)
            {
                Console.WriteLine("APROVADO!");
                Console.WriteLine("Nota final: " + A1.NotaTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                double pendencia = 60.00 - A1.NotaTotal();
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("Faltaram: " + pendencia.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
