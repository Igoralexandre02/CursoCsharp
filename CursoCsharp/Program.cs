using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using CursoCsharp.Entitys;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoa = [];
            
            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                var ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                var nome = Console.ReadLine();

                Console.Write("Anual income: ");
                var rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    var saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    pessoa.Add(new Pfísica(nome, rendaAnual, saude));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    var numFuncionarios = int.Parse(Console.ReadLine());

                    pessoa.Add(new Pjurídica(nome, rendaAnual, numFuncionarios));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("TAXES PAID: ");
            foreach (Pessoa p in pessoa)
            {
                Console.WriteLine(p.Nome + ": $" + p.Imposto().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            
            double sum = 0;
            foreach (Pessoa p in pessoa)
            {
                sum += p.Imposto();
            }
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}