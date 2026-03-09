using System;

namespace RefactorD
{
    class Program
    {
        // Main para pruebas
        static void Main(string[] args)
        {
            var clienteVip = new Cliente("VIP");
            var pedido = new Pedido(clienteVip, 200);

            Console.WriteLine($"Tipo cliente: {clienteVip.Tipo}");
            Console.WriteLine($"Total bruto: {pedido.Total()}");
            Console.WriteLine($"Total final: {pedido.TotalFinal()}");

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
