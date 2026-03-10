namespace Ejercicio2_SOLID_OCP_TarifasEnvio.Modelos;

public class EnvioEstandar : TarifaEnvio
{
    public override decimal CalcularCoste(decimal importePedido)
    {
        return importePedido >= 50 ? 0 : 4.95m;
    }
}
