namespace Ejercicio3_SOLID_DIP_ISP_Exportacion.Servicios;

public class ExportadorCsv : IExportador
{
    public void Exportar(string contenido)
    {
        Console.WriteLine($"CSV generado: {contenido}");
    }
}
