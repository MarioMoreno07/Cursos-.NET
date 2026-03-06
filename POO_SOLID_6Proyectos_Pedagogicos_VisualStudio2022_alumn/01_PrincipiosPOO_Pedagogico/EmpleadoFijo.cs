using System;

namespace PrincipiosPOO
{
    // ===============================
    // HERENCIA
    // ===============================
    // EmpleadoFijo ES un Empleado, y por eso "hereda" de Empleado.
    // Reutiliza Nombre y el constructor base.
    public class EmpleadoFijo : Empleado
    {
        public decimal SalarioMensual { get; set; }

        public EmpleadoFijo(string nombre, decimal salarioMensual) : base(nombre)
        {
            if (salarioMensual < 0) throw new ArgumentException("Salario inválido.");
            SalarioMensual = salarioMensual;
        }

        // ===============================
        // POLIMORFISMO (implementación)
        // ===============================
        public override decimal CalcularSalario() => SalarioMensual;
    }
}
