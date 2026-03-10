using Ejercicio2_SOLID_OCP_TarifasEnvio.Modelos;

namespace Ejercicio2_SOLID_OCP_TarifasEnvio;

internal class Program
{
    private static void Main(string[] args)
    {
        List<TarifaEnvio> tarifas = new()
        {
            new EnvioEstandar(),
            new EnvioUrgente(),
            new EnvioInternacional(),
            new EnvioRecogidaTienda()
        };

        decimal pedido = 100m;

        foreach (var tarifa in tarifas)
        {
            Console.WriteLine($"{tarifa.GetType().Name}: {tarifa.CalcularCoste(pedido):0.00} €");
        }
    }
}
