namespace CursoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            var NQ = int.Parse(Console.ReadLine());

            Pessoa[] Quartos = new Pessoa[10];
            Pessoa pessoa;

            for (int i = 0; i < NQ; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1) + ":");
                Console.Write("Nome: ");
                var nome = Console.ReadLine();
                Console.Write("Email: ");
                var email = Console.ReadLine();
                Console.Write("Quarto (De 0 a 9): ");
                var quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                pessoa = new Pessoa(nome, email, quarto);

                Quartos[quarto] = pessoa;
            }

            Console.WriteLine();

            Console.WriteLine("Quartos alugados: ");
            
            for (int i = 0; i < Quartos.Length; i++)
            {
                if (Quartos[i] != null)
                {
                    Console.WriteLine(Quartos[i].Quarto + ": " + Quartos[i].Nome + ", " + Quartos[i].Email);
                }
            }
        }
    }
}
