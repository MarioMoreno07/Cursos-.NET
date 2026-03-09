namespace Sesion2_Practica_Notificaciones
{
    /*
     * ServicioAvisos (alto nivel):
     * - Solo sabe que tiene una "notificación" para enviar.
     * - No sabe si es email, sms, etc.
     *
     * Esto permite cambiar la forma de notificar sin modificar esta clase.
     */
    public class ServicioAvisos
    {
        private readonly INotificacion _notificacion;

        // Inyección por constructor (muy común en proyectos profesionales)
        public ServicioAvisos(INotificacion notificacion)
        {
            _notificacion = notificacion;
        }

        public void Avisar(string destinatario, string mensaje)
        {
            _notificacion.Enviar(destinatario, mensaje);
        }
    }
}
