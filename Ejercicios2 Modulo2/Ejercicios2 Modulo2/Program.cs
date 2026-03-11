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
            Console.WriteLine("Mario");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine(DateTime.Now);
        }
        static internal void EJ3() {
            Console.WriteLine("Mario");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine(DateTime.Now);
        }
        static internal void EJ4() {
            Console.WriteLine("Mario");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine(DateTime.Now);
        }
        static internal void EJ5() {
            Console.WriteLine("Mario");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine(DateTime.Now);
        }
        static internal void EJ6() {
            Console.WriteLine("Mario");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine(DateTime.Now);
        }
        static internal void EJ7() {
            Console.WriteLine("Mario");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine(DateTime.Now);
        }
        static internal void EJ8() {
            Console.WriteLine("Mario");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine(DateTime.Now);
        }
        static internal void EJ9() {
            Console.WriteLine("Mario");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine(DateTime.Now);
        }
        static internal void EJ10() {
            Console.WriteLine("Mario");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine(DateTime.Now);
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

        
    }
}