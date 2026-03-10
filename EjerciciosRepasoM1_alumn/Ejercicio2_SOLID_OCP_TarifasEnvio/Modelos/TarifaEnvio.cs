namespace Ejercicio2_SOLID_OCP_TarifasEnvio.Modelos;

public abstract class TarifaEnvio
{
    public abstract decimal CalcularCoste(decimal importePedido);
}
