using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var P1 = new Produto();
            Console.WriteLine("Entre com os dados do produto.");

            Console.Write("Nome: ");
            P1.Nome = Console.ReadLine();

            Console.Write("Preco: ");
            P1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quatidade: ");
            P1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + P1);

            Console.Write("Adicionar mais unidades(S/N)?  ");
            string pergunta = Console.ReadLine();

            int quantidade;

            if (pergunta == "S")
            {
                Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                quantidade = int.Parse(Console.ReadLine());
                P1.AddProduto(quantidade);
                Console.WriteLine($"Dados do produto atualizados: " + P1);
            }

            Console.Write("Remover unidades(S/N)? ");
            pergunta = Console.ReadLine();
            if (pergunta == "S")
            {
                Console.Write("Digite o número de produtos a ser removido do estoque: ");
                quantidade = int.Parse(Console.ReadLine());
                P1.RemoverProduto(quantidade);
                Console.WriteLine($"Dados do produto atualizados: " + P1);

            }

            //var F1 = new Funcionario();
            //var F2 = new Funcionario();

            //Console.WriteLine("Dados do primeiro funcionario:");
            //Console.Write("Nome: ");
            //F1.Nome = Console.ReadLine();
            //Console.Write("Salario: ");
            //F1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Dados do segundo funcionario:");
            //Console.Write("Nome: ");
            //F2.Nome = Console.ReadLine();
            //Console.Write("Salario: ");
            //F2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //var mediaSalario = (F1.Salario + F2.Salario) / 2;
            //Console.WriteLine("A média dos salarios é igual a: " + mediaSalario.ToString("F3", CultureInfo.InvariantCulture));


            //var P1 = new Pessoa();
            //var P2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.Write("Nome: ");
            //P1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //P1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.Write("Nome: ");
            //P2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //P2.Idade = int.Parse(Console.ReadLine());

            //if (P1.Idade > P2.Idade)
            //    Console.WriteLine("Pessoa mais velha: " + P1.Nome);
            //else
            //    Console.WriteLine("Pessoa mais velha: " + P2.Nome);
        }
    }
}
