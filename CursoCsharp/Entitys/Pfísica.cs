using System;

namespace CursoCsharp.Entitys
{
    internal class Pfísica : Pessoa
    {
        public double Saude { get; set; }

        public Pfísica()
        { 
        }
        public Pfísica(string nome, double rendaAnual, double saude)
            : base(nome, rendaAnual)
        {
            Saude = saude;
        }

        public override double Imposto()
        {
            double imposto = 0.0;

            if (RendaAnual < 20000.00)
            {
                imposto += 15 * RendaAnual / 100;
            }
            else
            {
                imposto += 25 * RendaAnual / 100;
            }

            double impostoSaude = 0.0;
            if (Saude != 0)
            {
                impostoSaude += Saude / 2;
            }
            return imposto - impostoSaude;
        }
    }
}
