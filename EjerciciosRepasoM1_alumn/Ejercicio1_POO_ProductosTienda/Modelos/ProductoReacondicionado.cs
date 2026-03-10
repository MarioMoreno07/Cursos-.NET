using System;

namespace Ejercicio1_POO_ProductosTienda.Modelos {
    internal class ProductoReacondicionado : ProductoFisico {
        public ProductoReacondicionado(string nombre, decimal precioBase, decimal gastosEnvio) :
            base(nombre, precioBase, gastosEnvio) {
        }

 
       

        public override decimal CalcularPrecioFinal() {
            return (PrecioBase + GastosEnvio)*0.3m;
        }
    }
}
