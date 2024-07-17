using System;

namespace CursoCsharp.Entitys
{
    internal class Pjurídica : Pessoa
    {
        public int NumFuncionarios { get; set; }

        public Pjurídica()
        {
        }
        public Pjurídica(string nome, double rendaAnual, int numFuncionarios)
            : base(nome, rendaAnual)
        {
            NumFuncionarios = numFuncionarios;
        }

        public override double Imposto()
        {
            double imposto;

            if (NumFuncionarios < 10)
            {
                imposto = 16 * RendaAnual / 100;
            }
            else
            {
                imposto = 14 * RendaAnual / 100;
            }

            return imposto;
        }
    }
}
