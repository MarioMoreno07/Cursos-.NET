using System;


namespace Sesion3_MiniProyecto_Pedidos {
    internal class LineaPedido {
        string NombreProucto {  get; set; }
        int CantidadProducto {  get; set; }
        double PrecioProducto {  get; set; }

        public LineaPedido(string nombreProducto,int cantidadProducto,double precioProducto) {
            NombreProucto = nombreProducto;
            CantidadProducto = cantidadProducto;
            PrecioProducto = precioProducto;
        
        }
    }
}
