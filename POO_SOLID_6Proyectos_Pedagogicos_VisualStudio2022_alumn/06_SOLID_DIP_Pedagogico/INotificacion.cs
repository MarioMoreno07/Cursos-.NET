namespace SOLID_DIP
{
    /*
     * DIP - Dependency Inversion Principle (Inversión de Dependencias)
     *
     * Idea:
     * - El código "importante" (alto nivel) no debe depender de detalles concretos.
     * - Debe depender de una ABSTRACCIÓN (interfaz).
     *
     * Aquí la abstracción es INotificacion.
     */
    public interface INotificacion
    {
        void Enviar(string destinatario, string mensaje);
    }
}
