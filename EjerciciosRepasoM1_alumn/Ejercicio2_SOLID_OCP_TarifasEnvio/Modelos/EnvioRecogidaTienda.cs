using System;


namespace Ejercicio2_SOLID_OCP_TarifasEnvio.Modelos {
    internal class EnvioRecogidaTienda : TarifaEnvio {
        public override decimal CalcularCoste(decimal importePedido) {
            return  6.95m;
        }
    }
}
