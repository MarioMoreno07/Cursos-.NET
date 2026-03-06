using System;

namespace SOLID_OCP
{
    /*
     * Nuevo tipo de cliente añadido SIN modificar las clases anteriores.
     * Esto es exactamente lo que busca OCP.
     */
    public class ClienteNomal : Cliente
    {
        public ClienteNomal(string nombre) : base(nombre) { }
        public override double CalcularPrecio(double total) => total;
    }
}
