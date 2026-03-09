using System;

namespace RefactorA
{
     class CalculoHoras{
        public double CalcularTotal(int horas, double tarifa)
        {
            return horas * tarifa;
        }

        public string MostrarResumen(string nombre, double total)
        {
           return   nombre + total;
        }
    }
}
