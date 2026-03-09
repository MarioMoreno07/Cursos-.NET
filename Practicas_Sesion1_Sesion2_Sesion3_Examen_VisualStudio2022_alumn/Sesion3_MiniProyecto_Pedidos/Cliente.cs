using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion3_MiniProyecto_Pedidos {
    abstract class Cliente {
        string Nombre { get; set; }

        public Cliente(string nombre) {
            Nombre = nombre;
        }

        public abstract double CalcularDescuento(double bruto);
    }
}
