using System;
using System.Collections.Generic;

namespace Examen_Practico_Solucion_Empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Probamos la solución del examen:
             * - Creamos empleados de tipos distintos
             * - Llamamos al mismo método CalcularSalario()
             * - Cada uno responde distinto (polimorfismo)
             */

            var empleados = new List<Empleado>
            {
                new EmpleadoTemporal("Ana", 80, 12.5m),
                new EmpleadoFijo("Carlos", 1500m, 200m)
            };

            var printer = new NominaPrinter();
            printer.Imprimir(empleados);

            var calc = new CosteLaboralCalculator();
            Console.WriteLine($"Total empresa: {calc.CalcularTotal(empleados):0.00} €");

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
