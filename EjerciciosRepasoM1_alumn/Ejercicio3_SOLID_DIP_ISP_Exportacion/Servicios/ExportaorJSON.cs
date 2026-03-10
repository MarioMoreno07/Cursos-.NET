using System;


namespace Ejercicio3_SOLID_DIP_ISP_Exportacion.Servicios {
    internal class ExportaorJSON : IExportador {
        public void Exportar(string contenido) {
            Console.WriteLine($"JSON generado: {contenido}");
        }
    }
}
