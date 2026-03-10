using System;


namespace Sesion3_MiniProyecto_Pedidos {
    public class LineaPedido {
        internal string NombreProucto {  get; set; }
        internal int CantidadProducto {  get; set; }
        internal double PrecioProducto {  get; set; }

        public LineaPedido(string nombreProducto,int cantidadProducto,double precioProducto) {
            NombreProucto = nombreProducto;
            CantidadProducto = cantidadProducto;
            PrecioProducto = precioProducto;
        
        }

        public double Subtotal() {

            return PrecioProducto * CantidadProducto;
        }
    }
}
