using System.Globalization;

namespace Course {
    internal class Aluno {

        public string Nome;
        public double n1, n2, n3;
        double media = 60.00;

        public double TotalDeNotas() {
            return n1 + n2 + n3;
        }

        public override string ToString() {
            if(TotalDeNotas() >= media) {
                return "APROVADO \nNOTA FINAL = " + TotalDeNotas().ToString("F2", CultureInfo.InvariantCulture);
            } else {
                return "NOTA FINAL = " + TotalDeNotas().ToString("F2", CultureInfo.InvariantCulture) + "\nREPROVADO \nFALTARAM "
                    + (media - TotalDeNotas()).ToString("F2", CultureInfo.InvariantCulture)
                    + " PONTOS";
            }
        }

    }
}
