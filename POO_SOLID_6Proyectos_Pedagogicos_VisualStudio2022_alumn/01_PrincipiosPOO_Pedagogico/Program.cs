using System;
using System.Collections.Generic;

namespace PrincipiosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * POLIMORFISMO en acción:
             * La lista es de tipo Empleado (concepto general),
             * pero dentro metemos objetos de tipos concretos diferentes.
             */
            List<Empleado> empleados = new List<Empleado>
            {
                new EmpleadoFijo("Ana", 1500m),
                new EmpleadoPorHoras("Carlos", 80 , 12m)
            };

            foreach (var e in empleados)
            {
                // Misma llamada, distinto resultado según el tipo REAL del objeto.
                Console.WriteLine($"Empleado: {e.Nombre}");
                Console.WriteLine($"Salario calculado: {e.CalcularSalario():0.00} €");
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
