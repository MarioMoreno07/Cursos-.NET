using System;

namespace SOLID_OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 100;

            Cliente[] clientes =
            {
                new ClienteNomal("Ana"),
                new ClientePremium("Carlos"),
                new ClienteVIP("Lucía"),
                new ClienteGold("Pedro")
            };

            Console.WriteLine("== OCP en acción: mismo método, reglas distintas ==");
            foreach (var c in clientes)
            {
                Console.WriteLine($"{c.GetType().Name} ({c.Nombre}): {total} -> {c.CalcularPrecio(total)}");
            }

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
