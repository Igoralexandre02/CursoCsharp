using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp
{
    public static class ConversorDeMoedas
    {
        public static double IOF = 6.0;
        public static double Conversor(double cotacao, double dolar)
        {
            double valorDoDolar = dolar * cotacao;
            double valorComJuros = (valorDoDolar * IOF) / 100; 
            return valorDoDolar + valorComJuros;
        }
    }
}
