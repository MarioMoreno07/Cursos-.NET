using System;


namespace Sesion3_MiniProyecto_Pedidos {
    internal class ClienteVIP : Cliente {
        private double Descuento { get; set; } = 0.1;
        public ClienteVIP(string nombre) : base(nombre) {}

        public override double CalcularDescuento(double bruto) {
            return bruto * Descuento;
        }
    }
}
