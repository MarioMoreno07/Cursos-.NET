using System;

namespace SOLID_DIP
{
    // Implementación concreta (detalle): SMS
    public class SmsNotificacion : INotificacion
    {
        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine($"[SMS] Para: {destinatario} - {mensaje}");
        }
    }
}
