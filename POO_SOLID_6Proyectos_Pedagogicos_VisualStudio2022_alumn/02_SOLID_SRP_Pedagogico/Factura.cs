using System;

namespace SOLID_SRP
{
    /*
     * SRP - Single Responsibility Principle
     * (Principio de Responsabilidad Única)
     *
     * Idea:
     * - Una clase debe tener UNA sola razón para cambiar.
     *
     * Aquí, Factura solo se encarga del cálculo/estado de la factura.
     * No imprime y no guarda en base de datos.
     */
    public class Factura
    {
        public double ImporteBase { get; }

        public Factura(double importeBase)
        {
            if (importeBase < 0) throw new ArgumentException("Importe inválido.");
            ImporteBase = importeBase;
        }

        public double CalcularTotal()
        {
            // Ejemplo sencillo: el total es el importe base (sin impuestos).
            return ImporteBase;
        }
    }
}
