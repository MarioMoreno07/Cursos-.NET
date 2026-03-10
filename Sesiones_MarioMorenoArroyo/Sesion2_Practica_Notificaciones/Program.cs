using System;

namespace Sesion2_Practica_Notificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Probamos el mismo servicio con dos implementaciones distintas.
             * No cambiamos ServicioAvisos, solo cambiamos lo que le pasamos.
             */

            var servicioEmail = new ServicioAvisos(new EmailNotificacion());
            servicioEmail.Avisar("ana@correo.com", "Tu pedido está listo.");

            var servicioSms = new ServicioAvisos(new SmsNotificacion());
            servicioSms.Avisar("+34600000000", "Código de verificación: 1234");

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
