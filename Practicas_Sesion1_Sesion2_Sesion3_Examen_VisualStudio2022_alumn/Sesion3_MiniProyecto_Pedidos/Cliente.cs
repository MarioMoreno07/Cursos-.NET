using System;


namespace Sesion3_MiniProyecto_Pedidos {
    public abstract class Cliente {
        internal string Nombre { get; set; }

        public Cliente(string nombre) {
            Nombre = nombre;
        }

        public abstract double CalcularDescuento(double bruto);
    }
}
