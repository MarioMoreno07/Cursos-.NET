using System;

namespace SOLID_DIP
{
    // Implementación concreta (detalle): Email
    public class EmailNotificacion : INotificacion
    {
        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine($"[EMAIL] Para: {destinatario} - {mensaje}");
        }
    }
}
