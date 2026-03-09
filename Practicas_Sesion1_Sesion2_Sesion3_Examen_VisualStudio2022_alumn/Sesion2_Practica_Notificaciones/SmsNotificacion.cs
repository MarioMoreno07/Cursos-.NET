using System;


namespace Sesion2_Practica_Notificaciones {
    internal class SmsNotificacion : INotificacion {
        public void Enviar(string destinatario, string mensaje) {
            Console.WriteLine("El sms ha sido enviado al destinatario " + destinatario);
        }
    }
}
