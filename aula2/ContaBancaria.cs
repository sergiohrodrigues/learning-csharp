using System.Globalization;

namespace Course2 {
    internal class ContaBancaria {

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Sacar(double valor) {
            double taxaSaque = 5.00;
            Saldo -= valor + taxaSaque;
        }

        public override string ToString() {
            return
                "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
