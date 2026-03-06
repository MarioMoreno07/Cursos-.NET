using System;

namespace SOLID_OCP
{
    /*
     * Nuevo tipo de cliente añadido SIN modificar las clases anteriores.
     * Esto es exactamente lo que busca OCP.
     */
    public class ClienteGold : Cliente
    {
        public ClienteGold(string nombre) : base(nombre) { }
        public override double CalcularPrecio(double total) => total * 0.70;
    }
}
