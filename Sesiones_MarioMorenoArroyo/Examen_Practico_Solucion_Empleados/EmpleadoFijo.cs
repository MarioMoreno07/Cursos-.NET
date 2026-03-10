using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico_Solucion_Empleados {
    internal class EmpleadoFijo : Empleado {

        decimal Sueldo {  get; set; }
        decimal Bonos { get; set; }
        
        public EmpleadoFijo(string nombre, decimal sueldo , decimal bonos) : base(nombre) {
            Sueldo = sueldo;
            Bonos = bonos;
        }

        public override decimal CalcularSalario() {
            return Sueldo+Bonos;
        }
    }
}
