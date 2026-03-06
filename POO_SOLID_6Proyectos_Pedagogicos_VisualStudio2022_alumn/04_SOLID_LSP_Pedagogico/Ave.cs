using System;

namespace SOLID_LSP
{
    /*
     * LSP - Liskov Substitution Principle (Principio de Sustitución de Liskov)
     *
     * Idea sencilla:
     * - Si una clase B hereda de A, entonces debería poder usarse donde se espere A
     *   sin que el programa se rompa.
     *
     * Error típico:
     * - Crear una clase base con un método que NO todas las subclases pueden cumplir.
     *
     * Solución:
     * - Poner en la clase base SOLO lo común.
     * - Poner comportamientos opcionales en interfaces.
     */

    // Clase base: todas las aves pueden moverse.
    public abstract class Ave
    {
        public string Nombre { get; }

        protected Ave(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre inválido.");
            Nombre = nombre;
        }

        public abstract void Moverse();
    }
}
