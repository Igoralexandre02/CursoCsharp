using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp
{
    internal class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimentro()
        {
            return 2 * (Altura + Largura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
