using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorE { 
    class Envios {
        public double CalcularEnvio(double total,bool esIsla) {

            if (esIsla) {
                return total*100;
            }
            return total;
        }
    }
}
