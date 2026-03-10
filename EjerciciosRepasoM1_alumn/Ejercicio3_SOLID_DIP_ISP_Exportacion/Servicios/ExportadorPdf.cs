namespace Ejercicio3_SOLID_DIP_ISP_Exportacion.Servicios;

public class ExportadorPdf : IExportador
{
    public void Exportar(string contenido)
    {
        Console.WriteLine($"PDF generado: {contenido}");
    }
}
