using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora {
    public class CalculadoraApp {

        public double Sumar(double a, double b) {
            return a + b;
        }

        public double Resta(double a, double b) {
            return a - b;
        }

        public double Multiplicar(double a, double b) {
            return a * b;
        }

        public double Dividir(double a, double b) {
            double r = 0;

            if (b == 0) {
                throw new DivideByZeroException();
            } else {
                r = a / b;
            }

            return r;
        }

        public double Potencia(double basee, double exponente) {
            return Math.Pow(basee, exponente);
        }

        public double RaizCuadrada(double numero) {

            double r = 0;
            if (numero < 0) {
                throw new ArgumentException();
            } else {
                r= Math.Sqrt(numero);
            }
            return r;
        }
    
        public double Modulo(double a , double b ) {
            double  r = 0;
          
                if (b == 0) {
                    throw new DivideByZeroException();
                    
                } else { r = a % b; }
           
            return r;
        }

        public int Factorial(int numero) {

                if (numero < 0) {
                    
                    throw new ArgumentException();
                   
                } else {
                    int resultado = 1;
                    for (int i = 1; i <= numero; i++) {
                        resultado *= i;
                    }
                    return resultado;
                }
           
        }

        public double Porcentaje(double total, double porcentaje) {

            return (total * (porcentaje / 100));
        }

        public double Media(double[] numeros) { 
        
            double r = 0;
          
                if(numeros.Length == 0 ) {
                    throw new ArgumentNullException();
                } else {
                    r = numeros.Average();
                }
 
            return r;
        }
    }
}
