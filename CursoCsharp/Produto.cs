using System.Globalization;

namespace CursoCsharp
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotal()
        {
            return Preco * Quantidade;
        }
        public void AddProduto(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
