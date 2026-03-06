using System;

namespace SOLID_SRP
{
    /*
     * Responsabilidad ÚNICA: imprimir facturas.
     * Si cambia el formato de impresión, solo cambiamos esta clase.
     */
    public class FacturaPrinter
    {
        public void Imprimir(Factura factura)
        {
            Console.WriteLine("=== FACTURA ===");
            Console.WriteLine($"Importe base: {factura.ImporteBase:0.00} €");
            Console.WriteLine($"Total:       {factura.CalcularTotal():0.00} €");
            Console.WriteLine("===============");
        }
    }
}
