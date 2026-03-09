using System;



namespace RefactorB
{
    class CalculadoraBruto{

        public double CalcularBruto(int horas, double precioPorHoras){

            if(precioPorHoras > 0 && horas > 0)
            {
                return horas * precioPorHoras;
            }

            return 0;
        }
    }
}
