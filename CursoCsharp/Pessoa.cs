using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email {  get; set; }
        public int Quarto {  get; set; }

        public Pessoa(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }
    }
}
