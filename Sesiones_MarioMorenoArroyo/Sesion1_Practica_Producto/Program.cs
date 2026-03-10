using System;

namespace Sesion1_Practica_Producto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * MAIN: punto de entrada del programa (consola)
             * Aquí probamos la clase Producto.
             */

            try
            {
                // Creamos un producto
                var p = new Producto("Teclado", 25.00);
                p.MostrarInfo();

                // Aplicamos un 10% de descuento
                p.AplicarDescuento(0.10);
                p.MostrarInfo();

                // Prueba opcional (descomentar) para ver validación:
                // var p2 = new Producto("", -5);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
