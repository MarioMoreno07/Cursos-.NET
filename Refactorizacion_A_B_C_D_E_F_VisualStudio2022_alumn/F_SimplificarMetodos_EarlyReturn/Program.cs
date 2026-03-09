using System;

namespace RefactorF
{
    class Program
    {
        // Main para pruebas
        static void Main(string[] args)
        {
            var Edades = new Edades();
            int[] edades = { -1, 5, 17, 18, 30 };

            foreach (var e in edades)
            {
                Console.WriteLine($"Edad {e} => {Edades.ClasificarEdad(e)}");
            }

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
