using System;

namespace Examen_Practico_Solucion_Empleados
{
    /*
     * EXAMEN (Solución práctica)
     * Requisitos del enunciado:
     * - Gestionar EmpleadoBase / EmpleadoTemporal / EmpleadoFijo (tipos distintos)
     * - Cada uno calcula su salario diferente
     * - NO usar switch para el cálculo (usamos polimorfismo)
     * - Aplicar POO y buenas prácticas
     */

    // Clase abstracta: representa la idea general de empleado
    public abstract class Empleado
    {
        public string Nombre { get; }

        protected Empleado(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("Nombre inválido.");
            Nombre = nombre;
        }

        // Método abstracto: cada tipo de empleado define su cálculo
        public abstract decimal CalcularSalario();
    }
}
