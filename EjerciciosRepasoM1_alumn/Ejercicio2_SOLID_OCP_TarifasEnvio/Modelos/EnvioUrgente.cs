namespace Ejercicio2_SOLID_OCP_TarifasEnvio.Modelos;

public class EnvioUrgente : TarifaEnvio
{
    public override decimal CalcularCoste(decimal importePedido)
    {
        return 9.95m;
    }
}
