using System;

namespace RefactorE
{
    class Program
    {
        // Main para pruebas
        static void Main(string[] args)
        {
            
            Probar(60, false);
            Probar(60, true);
            Probar(20, false);
            Probar(20, true);

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }

        static void Probar(double total, bool esIsla)
        {
            var Envios = new Envios();
            double envio = Envios.CalcularEnvio(total, esIsla);
            Console.WriteLine($"Total={total}, esIsla={esIsla} => Envío={envio}");
        }
    }
}
