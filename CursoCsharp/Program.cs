using System.Globalization;
using System.Collections.Generic;


namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionário serão cadastrados? ");
            var NFun = int.Parse(Console.ReadLine());

            List<Funcionario> FunList = new List<Funcionario>();
            var Fun = new Funcionario();

            for (int i = 0; i < NFun; i++)
            {
                Console.Write("Id: ");
                var id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                var nome = Console.ReadLine();
                Console.Write("Salario: ");
                var salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                Fun = new Funcionario(id, nome, salario);

                FunList.Add(Fun);
            }

            Console.Write("Infome o Id do funcionário que receberá o aumento: ");
            var idFunc = int.Parse(Console.ReadLine());
            var count = 0;
            foreach (var item in FunList)
            {
                if (item.Id == idFunc)
                {
                    count++;
                }                
            }

            if (count >= 1)
            {
                Console.Write("Informe o valor da porcentagem: ");
                var porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                var fun = FunList.Find(f => f.Id == idFunc);
                fun.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id invalido!");
            }

            Console.WriteLine("Lista de funcionários atualizada: ");
            foreach (var item2 in FunList)
            {
                Console.WriteLine(item2.ToString());
            }
        }
    }
}
