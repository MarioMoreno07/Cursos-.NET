using System;

namespace RefactorB
{
    class Program{
        // Main para pruebas
        static void Main(string[] args)
        {
            var CalculadoraBruto=new CalculadoraBruto();
            try
            {
                Console.WriteLine("Bruto (80h, 12.5): " + CalculadoraBruto.CalcularBruto(80, 12.5));
                // Prueba de validación (descomenta para ver error controlado):
                Console.WriteLine("Bruto (-1h, 12.5): " +CalculadoraBruto.CalcularBruto(-1, 10));
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
