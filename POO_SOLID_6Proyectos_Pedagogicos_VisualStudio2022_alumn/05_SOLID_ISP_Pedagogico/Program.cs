using System;
using System.Collections.Generic;

namespace SOLID_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITrabajador> trabajadores = new List<ITrabajador>
            {
                new Humano("Ana"),
                new Robot("RX-1")
            };

            Console.WriteLine("== Todos trabajan ==");
            foreach (var t in trabajadores)
                t.Trabajar();

            Console.WriteLine();
            Console.WriteLine("== Solo algunos comen ==");
            foreach (var t in trabajadores)
            {
                if (t is IComedor comedor)
                    comedor.Comer();
                else
                    Console.WriteLine($"{t.GetType().Name}: no necesita comer.");
            }

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
