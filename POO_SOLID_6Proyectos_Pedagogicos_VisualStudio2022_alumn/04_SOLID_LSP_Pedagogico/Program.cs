using System;
using System.Collections.Generic;

namespace SOLID_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de Ave: todas deben funcionar con el contrato de Ave (Moverse).
            List<Ave> aves = new List<Ave>
            {
                new Aguila("Águila Real"),
                new Pinguino("Pingu")
            };

            Console.WriteLine("== LSP: todas las aves pueden moverse ==");
            foreach (var ave in aves)
            {
                ave.Moverse();
            }

            Console.WriteLine();
            Console.WriteLine("== Solo algunas aves vuelan ==");
            foreach (var ave in aves)
            {
                if (ave is IAveVoladora voladora)
                    voladora.Volar();
                else
                    Console.WriteLine($"{ave.Nombre}: no vuela (pero el programa NO falla).");
            }

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
