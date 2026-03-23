
namespace Calculadora {
    internal class Program {
        private static void Main(string[] args) {
            int opcion = -1;
            CalculadoraApp calculadora = new CalculadoraApp();

            do {
                Console.Clear();
                Console.WriteLine("\n === SISTEMA BIBLIOTECA === ");
                Console.WriteLine(" 1.Sumar ");
                Console.WriteLine(" 2.Restar");
                Console.WriteLine(" 3.Multiplicar ");
                Console.WriteLine(" 4.Dividir");
                Console.WriteLine(" 5. Potencia ");
                Console.WriteLine(" 6. Raiz Cuadrada");
                Console.WriteLine(" 7. Factorial ");
                Console.WriteLine(" 8. Porcentaje");
                Console.WriteLine(" 9. Media");
                Console.WriteLine(" 10. Modulo");
                Console.WriteLine(" 0.Salir ");
                bool esNum = int.TryParse(Console.ReadLine(), out opcion);

                while (!esNum) {
                    Console.WriteLine("Debes e introucir un numero");
                    esNum = int.TryParse(Console.ReadLine(), out opcion);
                }

                switch (opcion) {

                    case 0:
                        Console.WriteLine("Gracias por usar la calculadora, la proxima vez pulse la tecla widows y busca calculadora");
                        break;
                    case 1:
                        Console.WriteLine("Dime dos numeros");
                        bool parseSum1 = double.TryParse(Console.ReadLine(), out double numero1);
                        bool parseSum2 = double.TryParse(Console.ReadLine(), out double numero2);

                        Console.WriteLine("Resultado: " + calculadora.Sumar(numero1, numero2));
                        Console.WriteLine("Pulse para salir");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Dime dos numeros");
                        bool parseRes1 = double.TryParse(Console.ReadLine(), out double resta1);
                        bool parseRes2 = double.TryParse(Console.ReadLine(), out double resta2);

                        Console.WriteLine("Resultado: " + calculadora.Resta(resta1, resta2));
                        Console.WriteLine("Pulse para salir");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Dime dos numeros");
                        bool parseMul1 = double.TryParse(Console.ReadLine(), out double mult1);
                       bool parseMul2 = double.TryParse(Console.ReadLine(), out double mult2);

                        Console.WriteLine("Resultado: " + calculadora.Multiplicar(mult1, mult2));
                        Console.WriteLine("Pulse para salir");
                        Console.ReadLine();
                        break;
                    case 4:
                        try {
                            Console.WriteLine("Dime dos numeros");
                            bool parseDiv1 = double.TryParse(Console.ReadLine(), out double div1);
                            bool parseDiv2 = double.TryParse(Console.ReadLine(), out double div2);

                            Console.WriteLine("Resultado: " + calculadora.Dividir(div1, div2));
                        } catch(DivideByZeroException e) {
                            Console.WriteLine(e.Message);
                        }
                       
                        Console.WriteLine("Pulse para salir");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Dime un numeros");
                        bool parseBase = double.TryParse(Console.ReadLine(), out double basee);
                        bool parseExp = double.TryParse(Console.ReadLine(), out double exponente);

                        Console.WriteLine("Resultado: " + calculadora.Potencia(basee, exponente));
                        Console.WriteLine("Pulse para salir");
                        Console.ReadLine();
                        break;
                    case 6:
                        try {
                            Console.WriteLine("Dime un numeros");
                            bool parseRaiz = double.TryParse(Console.ReadLine(), out double raiz);

                            Console.WriteLine("Resultado: " + calculadora.RaizCuadrada(raiz));
                        }catch(ArgumentException e) {
                            Console.WriteLine(e.Message);
                        }
                        
                        Console.WriteLine("Pulse para salir");
                        Console.ReadLine();
                        break;
                    case 7:
                        try {
                            Console.WriteLine("Dime un numeros");
                            bool parseFact = int.TryParse(Console.ReadLine(), out int fact);


                            Console.WriteLine("Resultado: " + calculadora.Factorial(fact));
                        } catch (ArgumentException ex) {
                            
                            Console.WriteLine(ex.Message);
                        }
                     
                        Console.WriteLine("Pulse para salir");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Dime dos numeros");
                        bool parseTotal = double.TryParse(Console.ReadLine(), out double total);
                        bool parsePorcentaje = double.TryParse(Console.ReadLine(), out double porcentaje);

                        Console.WriteLine("Resultado: " + calculadora.Porcentaje(total, porcentaje));
                        Console.WriteLine("Pulse para salir");
                        Console.ReadLine();
                        break;
                    case 9:
                        try {
                            Console.WriteLine("¿De cuantos numeros quieres hacer la media?");
                            bool max = int.TryParse(Console.ReadLine(), out int num);
                            while (num < 0) {
                                Console.WriteLine("No puede ser menor a 0");
                                max = int.TryParse(Console.ReadLine(), out num);
                            }
                            double[] numeros = new double[num];
                            int i = 0;

                            while (i < numeros.Length) {
                                Console.WriteLine("Dime el numero");
                                bool parseNum = double.TryParse(Console.ReadLine(), out double numMedia);
                                numeros[i] = numMedia;
                                i++;
                            }

                            Console.WriteLine("Resultado: " + calculadora.Media(numeros));
                        }catch(ArgumentNullException e) {
                            Console.WriteLine(e.Message);
                        }
                        
                        Console.WriteLine("Pulse para salir");
                        Console.ReadLine();
                        break;
                    case 10:
                        try {
                            Console.WriteLine("Dime dos numeros");
                            bool parseA = double.TryParse(Console.ReadLine(), out double a);
                            bool parseB = double.TryParse(Console.ReadLine(), out double b);

                            Console.WriteLine("Resultado: " + calculadora.Modulo(a, b));
                        }catch(DivideByZeroException e){
                            Console.WriteLine(e.Message);
                        }

                      
                        Console.WriteLine("Pulse para salir");
                        Console.ReadLine();
                        break;

                }
                

            } while (opcion != 0 || opcion > 10);
        }
    }
}