using System;
using System.Data;
using System.Runtime.ConstrainedExecution;

namespace PrimerPrograma {
    internal class Program {
        private static void Main(string[] args) {
            menu();
        }
        static internal void menu() {
            int opcion = 1;
            while (opcion > 0 && opcion < 11) {
                Console.WriteLine("---------MENU---------");
                Console.WriteLine("1. Hola Mundo ampliado");
                Console.WriteLine("2. Presentación personal por consola");
                Console.WriteLine("3. Tabla informativa de tecnologías");
                Console.WriteLine("4. Comparativa C# vs Java");
                Console.WriteLine("5. Simulador del flujo de compilación");
                Console.WriteLine("6. Explorador textual de un proyecto Console");
                Console.WriteLine("7. Menú “Entorno de desarrollo”");
                Console.WriteLine("8. Generador de normas de estilo");
                Console.WriteLine("9. Proyecto: Asistente de instalación de Visual Studio");
                Console.WriteLine("10. Proyecto: Guía interactiva “Mi primer entorno C#”");
                Console.WriteLine("Selecciona una opcion, pulse otro numero para salir");
                bool parse = int.TryParse(Console.ReadLine(),out opcion);


                switch (opcion) {
                    case 1:
                        EJ1();
                        break;
                    case 2:
                        EJ2();
                        break;
                    case 3:
                        EJ3();
                        break;
                    case 4:
                        EJ4();
                        break;
                    case 5:
                        EJ5();
                        break;
                    case 6:
                        EJ6();
                        break;
                    case 7:
                        EJ7();
                        break;
                    case 8:
                        EJ8();
                        break;
                    case 9:
                        EJ9();
                        break;
                    case 10:
                        EJ10();
                        break;
                    default:
                        Console.WriteLine("Gracias por usar el menu , NO VUELVAS");
                        break;

                }

            }
        }
        static internal void EJ1() {
            Console.WriteLine("Mario");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine(DateTime.Now);
        }
        /**
         * En esta funcion escribo por pantalla mi nombe, edad, curso y afición
         */
        static internal void EJ2() {
            Console.WriteLine("Mario");
            Console.WriteLine("22 años");
            Console.WriteLine("Sevilla");
            Console.WriteLine("Mi aficion son los vieojuegos");
        }
        static internal void EJ3() {
            Console.WriteLine("C#|es un lenguaje de programación moderno, orientado a objetos y de propósito general," +
                " desarrollado por Microsoft como parte de su plataforma .NET");
            Console.WriteLine(".NET| Es una plataforma de desarrollo de software gratuita, de código abierto y multiplataforma, creada por Microsoft para construir, ejecutar y " +
                "desplegar diversos tipos de aplicaciones. ");
            Console.WriteLine("CLR|El Common Language Runtime (CLR) es el motor de ejecución fundamental de la plataforma .NET de Microsoft. Actúa como una máquina virtual" +
                " que gestiona la ejecución de programas");
            Console.WriteLine("IL|  Utilizado en automatización industrial, basado en un acumulador y similar al ensamblador");
            Console.WriteLine("JIT|  conocida como traducción dinámica, es una técnica para mejorar el rendimiento de sistemas de programación que compilan a bytecode");

        }
        static internal void EJ4() {
            Console.WriteLine("Diferencias entre JAVA y C#");
            Console.WriteLine("1.Rendimiento ");
            Console.WriteLine("2.Escalabilidad ");
            Console.WriteLine("3.Seguridad ");
            Console.WriteLine("Similitudes entre JAVA y C#");
            Console.WriteLine("1.Sintaxis similar ");
            Console.WriteLine("2.Ambos lenguajes oientados a objetos ");
            Console.WriteLine("3.Soporta constructores sobrecargados ");
            Console.WriteLine("4.Usan estrutura de multihilos ");
            Console.WriteLine("5.Se usan para servicios y programas parecidos ");

        }
        static internal void EJ5() {
            Console.WriteLine("Primero se escribe el codigo fuente en lenguaje C#," +
                "luego este codigo pasa por el compilador que a su vez pasa a IL o a MSIL, una vez ha pasado" +
                "por el CLR, pasa a lenguaje maquina gracias al JIT");
        }
        static internal void EJ6() {
            Console.WriteLine("Program.cs");
            Console.WriteLine(".csproj");
            Console.WriteLine("bin");
            Console.WriteLine("obj");
            Console.WriteLine("Dependencias");
            Console.WriteLine(" Analizadores");
            Console.WriteLine(" Marcos e trabajo");
        }
        static internal void EJ7() {
           menu2();
        }
        static internal void EJ8() {
            Console.WriteLine("Se debe usar PastelCase en Clases, Métodos, Namespaces, Propiedades y Eventos.");
            Console.WriteLine("Se debe usar camelCase en en variables locales y parámetros de métodos.");
            Console.WriteLine("Ejemplo correcto de PastelCase:ProfesorAuxiliar");
            Console.WriteLine("Ejemplo incorrecto de PastelCase:profesorNoAuxiliar");
            Console.WriteLine("Ejemplo correcto de camelCase:string mundoNuevo");
            Console.WriteLine("Ejemplo incorrecto de camelCase:string MundoNuevo");

        }
        static internal void EJ9() {
            Console.WriteLine("Primero debes comprobar que tu sistema operativo sea windows 10 o 11");
            Console.WriteLine("Segundo es recomendable tener minimo 8gb de ram");
            Console.WriteLine("Tercero tienes que elegir los paquetes de vayas a utilizar");
            Console.WriteLine("Cuarto tieens que instalar el sdk de .Net que vayas a necesitar");
            Console.WriteLine("Por ultimo ,una vez hayas hecho todo solo debes abir el programa");
        }
        static internal void EJ10() {
            menu3();
        }


        static void menu2() {
            int opcion = 1;
            while (opcion > 0 && opcion < 5) {
                Console.WriteLine("-----Menu2-----");
                Console.WriteLine("1.¿Qué es Visual Studio?");
                Console.WriteLine("2. Elementos principales del IDE");
                Console.WriteLine("3. Cómo ejecutar con F5 y Ctrl+F5");
                Console.WriteLine("4. Salir");
                bool parse = int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion) {
                    case 1:
                        Console.WriteLine("Visual Studio Code (VS Code) es un editor de código fuente gratuito y  ligero");
                        break;
                    case 2:
                        Console.WriteLine("Un editor de código fuente (con resaltado de sintaxis), un compilador/intérprete, un depurador (debugger) y herramientas de automatización de construcción");
                        break;
                    case 3:
                        Console.WriteLine("F5 -> Compila depurando");
                        Console.WriteLine("Ctrl+F5 -> Compila sin depurar");
                        break;
                    case 4:
                        opcion = 5;
                        break;
                    default:
                        Console.WriteLine("Numero no valido");
                        break;
 
                }

            }
        }

        static void menu3() {
            int opcion = 1;
            while (opcion > 0 && opcion < 7) {
                Console.WriteLine("-----Menu3-----");
                Console.WriteLine("1.¿Qué es C#?");
                Console.WriteLine("2. ¿Qué es .NET?");
                Console.WriteLine("3. ¿Qué es CLR?");
                Console.WriteLine("4. Estructura de un proyecto");
                Console.WriteLine("5. Cómo ejecutar un programa");
                Console.WriteLine("6. Salir");
                bool parse = int.TryParse(Console.ReadLine(), out opcion);

                switch (opcion) {
                    case 1:
                        Console.WriteLine("Es un lenguaje de programación moderno, orientado a objetos y de propósito general, desarrollado por Microsoft como parte de su plataforma .NET");
                        break;
                    case 2:
                        Console.WriteLine("Es una plataforma de desarrollo de software gratuita, de código abierto y multiplataforma, creada por Microsoft para construir, ejecutar y desplegar diversos tipos de aplicaciones.");
                        break;
                    case 3:
                        Console.WriteLine("El Common Language Runtime(CLR) es el motor de ejecución fundamental de la plataforma.NET de Microsoft.Actúa como una máquina virtual" +
                    " que gestiona la ejecución de programas");
                        break;
                    case 4:
                        EJ6();
                        break;
                    case 5:
                        Console.WriteLine("Para ejecutar el pograma puedes dale a F5 o ctrl+F5");
                        Console.WriteLine("F5 -> Compila depurando");
                        Console.WriteLine("Ctrl+F5 -> Compila sin depurar");
                        break;
                    case 6:
                        opcion = 10;
                        break;
                    default:
                        Console.WriteLine("Numero no valido");
                        break;

                }
            }
        }

    }
}