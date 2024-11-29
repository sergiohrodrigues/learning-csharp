using System.Globalization;

namespace Course {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quant) {
            Quantidade += quant;
        }

        public void RemoverProdutos(int quant) {
            Quantidade -= quant;
        }

        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
