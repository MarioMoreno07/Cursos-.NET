using System;

namespace RefactorD
{
    /// <summary>
    /// Ejemplo D: TRASLADO DE FUNCIONES ENTRE OBJETOS (Move Method)
    /// La lógica del descuento pertenece al Cliente (política comercial),
    /// no al Pedido.
    /// </summary>
    public class Cliente
    {
        public string Tipo { get; }

        public Cliente(string tipo)
        {
            Tipo = tipo;
        }

        // Método "movido" aquí: el Cliente decide su descuento
        public double CalcularDescuento(double total)
        {
            return Tipo switch
            {
                "VIP" => total * 0.2,
                "Premium" => total * 0.1,
                _ => 0
            };
        }
    }
}
