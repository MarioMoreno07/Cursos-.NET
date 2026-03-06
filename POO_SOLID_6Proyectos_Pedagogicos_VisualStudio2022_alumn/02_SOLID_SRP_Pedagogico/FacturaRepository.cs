using System;

namespace SOLID_SRP
{
    /*
     * Responsabilidad ÚNICA: imprimir facturas.
     * Si cambia el formato de impresión, solo cambiamos esta clase.
     */
    public class FacturaRepositoy
    {
        public void Imprimir(Factura factura)
        {

            Console.WriteLine("Guardado en base de datos");
            Console.WriteLine("===============");
        }
    }
}
