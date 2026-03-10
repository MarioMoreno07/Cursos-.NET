using System;


namespace Sesion3_MiniProyecto_Pedidos
{
    /*
     * Clase Pedido: su responsabilidad principal es gestionar líneas
     * y calcular totales.
     *
     * Importante:
     * - Pedido NO imprime (eso lo hace PedidoPrinter) => SRP.
     */
    public class Pedido
    {
        private readonly List<LineaPedido> _lineas = new();

        public Cliente Cliente { get; }

        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
        }

        public void AgregarLinea(LineaPedido linea) => _lineas.Add(linea);

        public IReadOnlyList<LineaPedido> Lineas => _lineas;

        public double TotalBruto() => _lineas.Sum(l => l.Subtotal());

        public double TotalFinal()
        {
            var bruto = TotalBruto();
            var descuento = Cliente.CalcularDescuento(bruto);
            return bruto - descuento;
        }
    }
}
