using System;


namespace Examen_Practico_Solucion_Empleados {
    internal class NominaPrinter {

        public void Imprimir(List<Empleado> empleados) {

            foreach(var empleado in empleados) {
                Console.WriteLine("El empleado "+empleado.Nombre+" ha ganado un total de "
                    +empleado.CalcularSalario()+"euros");
            }

        }
    }
}
