using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    internal class ConversorDeMoeda {

        public static double Iof = 6.0;
        public static double DolarAtual;

        public static double ConverterDolarEmReal(double v) {
            return v * DolarAtual + ((v * DolarAtual) * Iof/100);
        }

    }
}
