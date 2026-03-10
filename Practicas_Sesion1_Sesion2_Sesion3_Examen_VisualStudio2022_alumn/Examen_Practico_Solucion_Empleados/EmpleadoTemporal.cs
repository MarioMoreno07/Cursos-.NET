using System;


namespace Examen_Practico_Solucion_Empleados {
    class EmpleadoTemporal : Empleado {

        int Horas { get; set; }
        decimal PrecioPorHoras { get; set; }


        public EmpleadoTemporal(string nombre, int horas , decimal precioPorHoras) : base(nombre) {
            Horas = horas;
            PrecioPorHoras = precioPorHoras;
        }

        public override decimal CalcularSalario() {
            return Horas * PrecioPorHoras;
        }
    }
}
