namespace Sesion2_Practica_Notificaciones
{
    /*
     * SESIÓN 2 (Módulo 1): SOLID aplicado a un caso muy sencillo.
     *
     * DIP (Dependency Inversion Principle):
     * - El servicio de avisos NO debe depender directamente de Email o SMS.
     * - Debe depender de una ABSTRACCIÓN: esta interfaz INotificacion.
     */
    public interface INotificacion
    {
        void Enviar(string destinatario, string mensaje);
    }
}
