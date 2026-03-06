using System;

namespace SOLID_DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elegimos una implementación concreta (Email)
            INotificacion email = new EmailNotificacion();
            var servicioEmail = new ServicioAvisos(email);
            servicioEmail.Avisar("ana@correo.com", "Tu pedido está listo.");

            // Cambiamos a SMS SIN modificar ServicioAvisos
            INotificacion sms = new SmsNotificacion();
            var servicioSms = new ServicioAvisos(sms);
            servicioSms.Avisar("+34600000000", "Código: 1234");

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
