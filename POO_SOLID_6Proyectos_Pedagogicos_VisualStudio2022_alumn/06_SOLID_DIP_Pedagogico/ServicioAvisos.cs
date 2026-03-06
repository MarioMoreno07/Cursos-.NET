namespace SOLID_DIP
{
    /*
     * ServicioAvisos es "alto nivel" porque contiene lógica de negocio (avisar).
     * Si dependiera directamente de EmailNotificacion, estaría acoplado.
     *
     * Gracias a DIP:
     * - ServicioAvisos depende de INotificacion (abstracción).
     * - Podemos inyectar Email o SMS desde fuera.
     */
    public class ServicioAvisos
    {
        private readonly INotificacion _notificacion;

        // Inyección por constructor: elegimos la dependencia desde fuera.
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
