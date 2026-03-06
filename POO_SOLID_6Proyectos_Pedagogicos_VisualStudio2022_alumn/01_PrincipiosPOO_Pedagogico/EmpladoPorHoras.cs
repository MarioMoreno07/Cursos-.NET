using System;

namespace PrincipiosPOO
{
	// ===============================
	// HERENCIA
	// ===============================
	// EmpleadoFijo ES un Empleado, y por eso "hereda" de Empleado.
	// Reutiliza Nombre y el constructor base.
	public class EmpleadoPorHoras : Empleado
	{
		public decimal PrecioPorHoras { get; set; }
		public decimal Horas { get; set; }

		public EmpleadoPorHoras(string nombre, decimal precioPorHoras,decimal horas) : base(nombre)
		{
			if (PrecioPorHoras < 0) throw new ArgumentException("Salario inválido.");
			PrecioPorHoras = precioPorHoras;
			Horas = horas;
		}

		// ===============================
		// POLIMORFISMO (implementación)
		// ===============================
		public override decimal CalcularSalario() => Horas * PrecioPorHoras;
	}
}
