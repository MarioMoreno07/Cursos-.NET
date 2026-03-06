using System;

namespace SOLID_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var factura = new Factura(100);
            var printer = new FacturaPrinter();
            var repo = new FacturaRepository();

            // Factura: calcula
            Console.WriteLine("Total calculado: " + factura.CalcularTotal());

            // Printer: imprime
            printer.Imprimir(factura);

            // Repository: guarda
            repo.Guardar(factura);

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
