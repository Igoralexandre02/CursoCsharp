using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            Salario += (porcentagem * Salario) / 100;
        }

        public override string ToString()
        {
            return Id 
                + ", " 
                + Nome 
                + ", " 
                + Salario.ToString("F2", CultureInfo.InvariantCulture) 
                + ".";
        }
    }
}
