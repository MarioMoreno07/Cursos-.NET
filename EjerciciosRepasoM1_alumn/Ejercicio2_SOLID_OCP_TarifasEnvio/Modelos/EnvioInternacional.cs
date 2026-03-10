namespace Ejercicio2_SOLID_OCP_TarifasEnvio.Modelos;

public class EnvioInternacional : TarifaEnvio
{
    public override decimal CalcularCoste(decimal importePedido)
    {
        return 19.95m;
    }
}
