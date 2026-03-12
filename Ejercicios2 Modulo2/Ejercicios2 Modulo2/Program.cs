using System;
using System.Globalization;

namespace EjeciciosModulo2 {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");
            menu();
            /*
             *
             *
             * Aquí tienes el desglose de lo que hace cada línea:
                Console.OutputEncoding = Encoding.UTF8;: Permite que la consola muestre símbolos como tildes (á), eñes (ñ) o el símbolo del euro (€) sin que se transformen en caracteres extraños.
                CultureInfo.DefaultThreadCurrentCulture: Define el formato de datos (fechas como dd/mm/aaaa, números con coma decimal, moneda) para toda la aplicación.
                CultureInfo.DefaultThreadCurrentUICulture: Define el idioma de la interfaz (los mensajes de error del sistema o recursos de texto localizados).
                Nota: Asegúrate de incluir using System.Text; y using System.Globalization; al inicio de tu archivo para que estas clases estén disponibles.
             *
             *
             *
             *
             */

        }

        static internal void menu() {
            int opcion = 1;
            while (opcion > 0 && opcion < 11) {
                
                Console.WriteLine("---------MENU---------");
                Console.WriteLine("1. Ficha de usuario");
                Console.WriteLine("2. Calculadora de suma y resta");
                Console.WriteLine("3. Conversor de tipos");
                Console.WriteLine("4. Analizador de número");
                Console.WriteLine("5. Conversor de edad");
                Console.WriteLine("6. Calculadora de media de notas");
                Console.WriteLine("7. Conversor euros a dólares");
                Console.WriteLine("8. Detector de número par o impar");
                Console.WriteLine("9. Proyecto: Calculadora profesional básica");
                Console.WriteLine("10. Proyecto: Gestor de datos personales");
                Console.WriteLine("Selecciona una opcion, pulse otro numero para salir");
                bool parse = int.TryParse(Console.ReadLine(), out opcion);


                switch (opcion) {
                    case 1:
                        EJ1();
                        Console.Clear();
                        break;
                    case 2:
                        EJ2();
                        Console.Clear();
                        break;
                    case 3:
                        EJ3();
                        Console.Clear();
                        break;
                    case 4:
                        EJ4();
                        Console.Clear();
                        break;
                    case 5:
                        EJ5();
                        Console.Clear();
                        break;
                    case 6:
                        EJ6();
                        Console.Clear();
                        break;
                    case 7:
                        EJ7();
                        Console.Clear();
                        break;
                    case 8:
                        EJ8();
                        Console.Clear();
                        break;
                    case 9:
                        EJ9();
                        Console.Clear();
                        break;
                    case 10:
                        EJ10();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Gracias por usar el menu , NO VUELVAS");
                        break;

                }

                
            }

        }
        static internal void EJ1() {
            int edad;
            double altura;
            string estudiante;
            string nombre="ab";

            Console.WriteLine("Diga su nombre");
            nombre = Console.ReadLine();
            char inicial = nombre.ToCharArray().First();
            Console.WriteLine("Diga su edad");
            bool parse = int.TryParse(Console.ReadLine(), out edad);
            if (edad <= 0 || edad > 100) {
                Console.WriteLine("Edad no valida.Escriba una edad valida");
                parse = int.TryParse(Console.ReadLine(), out edad);
                
            }
            Console.WriteLine("Diga su altura en cm");
            bool parseAltura = double.TryParse(Console.ReadLine(), out altura);
            if(altura < 0 || altura > 220) {
                Console.WriteLine("Altura no valida.Escriba una altura valida");
                parseAltura = double.TryParse(Console.ReadLine(), out altura);
            }
            Console.WriteLine("Es usted estudiante");
            bool esEstudiante = ComprobarEstudiante();
            if (esEstudiante == true) {  estudiante = "si"; } else { estudiante = "no"; }

                Console.WriteLine("Nombre:" + nombre + " Edad:" + edad + " Altura:" + altura + " Estudiante:" + estudiante+" Incial:"+inicial);
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        
        }
        static internal void EJ2() {
            Console.WriteLine("Dime dos numeros enteros");
            int num1 = int.Parse(PedirType(typeof(int)));
            int  num2 = int.Parse(PedirType(typeof(int)));
         
            Console.WriteLine("La suma de estos numeros es: " + (num1+num2));
            Console.WriteLine("La resta de estos numeros es: " + (num1 - num2));
            Console.WriteLine("La multiplicacion de estos numeros es: " + (num1 * num2));
            if (num2 != 0) {
                Console.WriteLine("La division de estos numeros es: " + (num1 / num2));
                Console.WriteLine("El resto de estos numeros es: " + (num1 % num2));
            } else { Console.WriteLine("No se puede hacer la division ni el resto"); }
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ3() {
            Console.WriteLine("Vamos a pasar un numero entero a decimal, introduzca el entero");
            int entero = int.Parse(PedirType(typeof(int)));
            Console.WriteLine("Vamos a pasar un numero decimal a entero, introduzca el decimal, tienes que hacerlos con ','");
            double deciimal= double.Parse(PedirType(typeof(double))); ;
            Console.WriteLine("El valor del entero es: " + entero + " convertido a decimal seria: "+Convert.ToDecimal(entero).ToString("F2"));
            Console.WriteLine("El valor del entero es: " + deciimal + " convertido a decimal seria: "+Convert.ToInt32(deciimal));
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ4() {
            Console.WriteLine("Dime un nuevo entero");
            int numero= int.Parse(PedirType(typeof(int)));
            Console.WriteLine("Es mayor que 0: " + Comparar(numero, "mayor", 0));
            Console.WriteLine("Es menor que 100: " + Comparar(numero, "menor", 100));
            Console.WriteLine("Es igual a 50: " + Comparar(numero, "igual", 50));
            Console.WriteLine("Es distinto de 10: "+Comparar(numero, "!=", 10));
            Console.WriteLine("Es mayor 60 , menor que 200 , diferente a 77 e igual a 80: "+(Comparar(numero,"mayor",60) && Comparar(numero, "menor", 200) && Comparar(numero, "diferente", 77) && Comparar(numero, "igual", 80) ));
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();



        }
        static internal void EJ5() {
            Console.WriteLine("Dime tu año de nacimiento y te dire tu edad:");
            int ano = Convert.ToInt32(Console.ReadLine());
            int edad = DateTime.Today.Year - ano;
            Console.WriteLine("Su edad es: " + edad);
            int meses = edad * 12;
            Console.WriteLine("Sus edad en meses es: " + meses);
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();

        }
        static internal void EJ6() {
            double nota1, nota2, nota3,notaFinal;
            Console.WriteLine("Dime la nota de tus examenes, recuerda que si hay decimales lo tienes que poner con ','");
            nota1 = double.Parse(PedirType(typeof(double)));
            nota2 = double.Parse(PedirType(typeof(double)));
            nota3 = double.Parse(PedirType(typeof(double)));
            notaFinal = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("La nota final es de : " + notaFinal.ToString("F3"));
            if (Comparar((int)(notaFinal), ">=", 5)){
                Console.WriteLine("Has aprobado");
            } else { Console.WriteLine("Suspensoo"); }
                Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ7() {
            Console.WriteLine("Vamos a pasar de euros a dolares, recuerda que si hay decimales lo tienes que poner con ','");
            double euros = double.Parse(PedirType(typeof(double)));
            double taxa =1.16;
            double dolares = euros * taxa;
            Console.WriteLine("Has seleccionado :" + euros.ToString("F2")+" euros");
            Console.WriteLine("En dolares serian: "+dolares.ToString("F2")+" dolares");
           
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ8() {
            Console.WriteLine("Dime un numero y te dire si es par o impar");
            double numero = double.Parse(PedirType(typeof(double)));
            if(Comparar((int)numero, "mayor o igual", 0)) {
                Console.WriteLine("El numero es positivo");
            } else { Console.WriteLine("El numero es negativo"); }
            if (esPar(numero)) {
                Console.WriteLine("El numero es par");
            } else { Console.WriteLine("El numero es impar"); }

            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ9() {
            EJ2();
            
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ10() {
            Console.WriteLine("Dime tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dime tu edad");
            int edad = int.Parse(PedirType(typeof(int)));
            while(Comparar(edad,"menor",0) || Comparar(edad, "mayor", 100)) {
                Console.WriteLine("La edad tiene que ser mayor que 0 y menor que 100");
                edad = int.Parse(PedirType(typeof(int)));
            }
            Console.WriteLine("Dime tu ciudad");
            string ciudad = Console.ReadLine();
            Console.WriteLine("Dime tu salario mensual");
            double salarioMensual = double.Parse(PedirType(typeof(double)));
            while (Comparar((int)salarioMensual, "<=", 0)) {
                Console.WriteLine("El salario no puede ser menor a 0");
                salarioMensual = double.Parse(PedirType(typeof(double)));
            }
            
            Console.WriteLine("Dime tu año de nacimiento");
            int añDeNacimiento = int.Parse(PedirType(typeof(int)));
            while (Comparar(edad, "!=", DateTime.Today.Year-añDeNacimiento)) {
                Console.WriteLine("Tu edad y tu año de nacimiento no concuerdan,si este año aun no has cumplido años , sumate un año");
                edad = int.Parse(PedirType(typeof(int)));
            }
                Console.WriteLine("El usuario "+nombre+" el cual tiene "+edad+" años y vive en "+ciudad+
                " cobra "+salarioMensual+" euros y nacio en el año "+añDeNacimiento);

            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }

        public static bool ComprobarEstudiante() {
            bool r = false;
            string comprobando = Console.ReadLine().ToLower();

            if(comprobando == "si") {
                r = true;
            }else if(comprobando == "no") {
                r= false;
            } else {
                Console.WriteLine("Tiene que ser Si o No");
                ComprobarEstudiante();
                
            }
                return r;
        }

        private static string PedirType(Type type) {

            var r = 0;

            if(type == typeof(int)) {
                bool parseNum1 = int.TryParse(Console.ReadLine(), out r);
                if (!parseNum1) {
                    Console.WriteLine("Porfavor introduzca un numero");
                    PedirType(type);
                }
                return r.ToString();
            }

            var d = 0.0;
            if (type == typeof(double)) {
                bool parseNum1 = double.TryParse(Console.ReadLine(), out d);
                if (!parseNum1) {
                    Console.WriteLine("Porfavor introduzca un numero");
                    PedirType(type);
                }
                return d.ToString();
            }

            return r.ToString();

        }

        public static bool Comparar(int num , string comparador , int comparacion) {
            bool resultado = false;
            switch (comparador) {

                case (">" or "mayor"):
                    if (num > comparacion) {
                        resultado = true;
                    }
                    break;
                case ("<" or "menor"):
                     if (num < comparacion) {
                        resultado = true;
                    }
                    break;
                case ("=" or "==" or "igual"):
                    if(num == comparacion) {
                        resultado = true;
                    }
                    break;
                case ("!" or "!=" or "distinto" or "diferente"):
                    if (num != comparacion) {
                        resultado = true;
                    }
                    break;
                case (">=" or "mayor o igual"):
                    if (num >= comparacion) {
                        resultado = true;
                    }
                    break;
                case ("<=" or "menor o igual"):
                    if (num <= comparacion) {
                        resultado = true;
                    }
                    break;

            }
            return resultado;

        }

        public static bool esPar(double num) {
            bool r = false;
            if(num % 2 == 0) {
                r=true;
            }

            return r;
        }



         
        }

        
    }
