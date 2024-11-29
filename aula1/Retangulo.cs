using System.Globalization;

namespace Course {
    internal class Retangulo {

        public double Largura, Altura;

        public double Area() {
            return Largura * Altura;
        }

        public double Perimetro() {
            return (Largura + Largura) + (Altura + Altura);
        }
        public double Diagonal() { 
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString() {
            return "Área = "
                + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "Perímetro = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "Diagonal = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
