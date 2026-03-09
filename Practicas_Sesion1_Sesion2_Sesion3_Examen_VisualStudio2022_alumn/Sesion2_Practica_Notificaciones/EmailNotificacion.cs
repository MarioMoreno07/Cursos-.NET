using System;


namespace Sesion2_Practica_Notificaciones {
    internal class EmailNotificacion : INotificacion {
        public void Enviar(string destinatario, string mensaje) {
            Console.WriteLine("El correo ha sido enviado al destinatario " + destinatario);
        }
    }
}
