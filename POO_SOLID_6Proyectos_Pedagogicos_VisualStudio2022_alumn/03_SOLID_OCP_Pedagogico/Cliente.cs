using System;

namespace SOLID_OCP
{
    /*
     * OCP - Open/Closed Principle (Principio Abierto/Cerrado)
     *
     * "Abierto a extensión": podemos añadir nuevos tipos de cliente.
     * "Cerrado a modificación": NO queremos tocar código existente para añadirlos.
     *
     * Para lograrlo, usamos:
     * - Una clase base abstracta (Cliente) con un método abstracto.
     * - Varias clases hijas que implementan su propia regla de descuento.
     */
    public abstract class Cliente
    {
        public string Nombre { get; }

        protected Cliente(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre inválido.");
            Nombre = nombre;
        }

        // Cada tipo de cliente calcula el precio final a su manera.
        public abstract double CalcularPrecio(double total);
    }
}
