using System;


namespace Sesion3_MiniProyecto_Pedidos {
    public class PedidoPrinter {

        public void Imprimir(Pedido pedido) {

            foreach (var item in pedido.Lineas) {
                Console.WriteLine("El clinte ha comprado "+item.CantidadProducto+" "+
                    item.NombreProucto+"con un precio de "+item.Subtotal());
            }

            Console.WriteLine("El cliente " + pedido.Cliente.Nombre +
                "tiene que pagar un total de " + pedido.TotalFinal());
        }
    }
}
