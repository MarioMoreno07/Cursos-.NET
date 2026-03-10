using System.Collections.Generic;
using System.Linq;

namespace Examen_Practico_Solucion_Empleados
{
    /*
     * Clase dedicada al cálculo del coste total (otra responsabilidad separada).
     */
    public class CosteLaboralCalculator
    {
        public decimal CalcularTotal(IEnumerable<Empleado> empleados)
            => empleados.Sum(e => e.CalcularSalario());
    }
}
