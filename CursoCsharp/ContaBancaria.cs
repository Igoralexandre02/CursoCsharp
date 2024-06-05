using System.Globalization;
namespace CursoCsharp
{
    internal class ContaBancaria
    {
        public string Nome { get; private set; }
        public int Nconta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int nconta, string nome)
        {
            Nconta = nconta;
            Nome = nome;
        }

        public double Deposito(double V)
        {
            return Saldo += V;
        }
        
        public double Saque(double V)
        {
            return Saldo -= V + 5;
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
