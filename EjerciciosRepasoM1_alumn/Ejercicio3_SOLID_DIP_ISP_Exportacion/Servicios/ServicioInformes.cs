namespace Ejercicio3_SOLID_DIP_ISP_Exportacion.Servicios;

public class ServicioInformes
{
    private readonly IExportador _exportador;

    public ServicioInformes(IExportador exportador)
    {
        _exportador = exportador;
    }

    public void Exportar(string contenido)
    {
        _exportador.Exportar(contenido);
    }
}
