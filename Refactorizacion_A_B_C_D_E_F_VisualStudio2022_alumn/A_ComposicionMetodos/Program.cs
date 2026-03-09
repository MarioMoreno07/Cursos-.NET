using System;
using System.Security.Cryptography.X509Certificates;

namespace RefactorA
{
    class Program
    {
        // Main para pruebas
        static void Main(string[] args)
        {
            string nombre = "Ana";
            int horas = 42;
            double tarifa = 15;
            var CalculoHoras = new CalculoHoras();

            // Con composición de métodos: más legible, más testeable
            double total = CalculoHoras.CalcularTotal(horas, tarifa);
            Console.WriteLine(total);
            Console.WriteLine(CalculoHoras.MostrarResumen(nombre, total));

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();

        }
    }
}
