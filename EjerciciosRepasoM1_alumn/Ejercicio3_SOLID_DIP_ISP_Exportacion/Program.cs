using Ejercicio3_SOLID_DIP_ISP_Exportacion.Servicios;

namespace Ejercicio3_SOLID_DIP_ISP_Exportacion;

internal class Program
{
    private static void Main(string[] args)
    {
        IExportador exportadorCsv = new ExportadorCsv();
        var servicioCsv = new ServicioInformes(exportadorCsv);
        servicioCsv.Exportar("Ventas del mes");

        IExportador exportadorPdf = new ExportadorPdf();
        var servicioPdf = new ServicioInformes(exportadorPdf);
        servicioPdf.Exportar("Resumen anual");

        IExportador exportadorJSON = new ExportaorJSON();
        var servicioJSON = new ServicioInformes(exportadorJSON);
        servicioJSON.Exportar("Resumen anual");
    }
}
