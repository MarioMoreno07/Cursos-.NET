using System;

namespace Sesion3_MiniProyecto_Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Probamos el mini-proyecto con un cliente VIP.
             * Cambia ClienteVIP por ClienteNormal/ClientePremium para ver diferencias.
             */

            Cliente cliente = new ClienteVIP("Carlos");
            var pedido = new Pedido(cliente);

            pedido.AgregarLinea(new LineaPedido("Ratón", 2, 12.50));
            pedido.AgregarLinea(new LineaPedido("Teclado", 1, 25.00));

           var printer = new PedidoPrinter();
            printer.Imprimir(pedido);

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
