using System.Globalization;
namespace CursoCsharp
{
    internal class ContaBancaria
    {
        public string Nome { get; private set; }
        public int Nconta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int nconta)
        {
            Nome = nome;
            Nconta = nconta;
        }

        public ContaBancaria(string nome, int nconta, double saldo) : this(nome, nconta)
        {
            Saldo = saldo;
        }

        public void Deposito(double V)
        {
            Saldo += V;
        }

        public void Saque(double V)
        {
            Saldo -= V + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + Nconta
                + ", Titular: "
                + Nome
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
