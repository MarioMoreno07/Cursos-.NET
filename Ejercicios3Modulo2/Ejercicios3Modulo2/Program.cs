using System;
using System.Globalization;

namespace Ejercicio2Modulo2 {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");
            menu();
           

        }
        static internal void menu() {
            int opcion = 1;
            while (opcion > 0 && opcion < 11) {

                Console.WriteLine("---------MENU---------");
                Console.WriteLine("1. Presentación con concatenación tradicional");
                Console.WriteLine("2.Presentación con interpolación");
                Console.WriteLine("3. Error clásico de concatenación");
                Console.WriteLine("4. Formato de precio");
                Console.WriteLine("5. Formato de porcentaje");
                Console.WriteLine("6. Informe alineado en consola");
                Console.WriteLine("7. Formato compuesto clásico");
                Console.WriteLine("8. Proyecto: Ticket de compra");
                Console.WriteLine("9. Proyecto: Nómina básica");
                Console.WriteLine("10. Proyecto: Generador de informe personal formateado");
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

            Console.WriteLine("Dime tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dime tu edad");  
            int edad = int.Parse(PedirType(typeof(int)));
            while(Comparar(edad,"<",0) || Comparar(edad, ">", 100)) {
                Console.WriteLine("La edad tiene q ser mayor a 0 y menor a 100");
                edad = int.Parse(PedirType(typeof(int)));
            }
            Console.WriteLine("Dime la ciudad donde vives");
            string ciudad = Console.ReadLine();
            Console.WriteLine("El usuario se llama "+nombre+" tiene "+edad+" años y vive en "+ciudad);
            Console.WriteLine("Buenas noches usuario");
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ2() {
            Console.WriteLine("Dime tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Dime tu edad");  
            int edad = int.Parse(PedirType(typeof(int)));
            while(Comparar(edad,"<",0) || Comparar(edad, ">", 100)) {
                Console.WriteLine("La edad tiene q ser mayor a 0 y menor a 100");
                edad = int.Parse(PedirType(typeof(int)));
            }
            Console.WriteLine("Dime la ciudad donde vives");
            string ciudad = Console.ReadLine();
            Console.WriteLine($"El usuario se llama {edad} tiene {edad} años y vive en {ciudad}");
            Console.WriteLine($"La suma de 5 + 5 es: {5+5}");
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ3() {
            int a = 5;
            int b = 3;

            Console.WriteLine("La suma es: "+a+b);
            Console.WriteLine($"La suma es: {a+b}");
            Console.WriteLine("La primera da error debido a que falta un parerentesis que recoga a+b y los detecta como string diferentes");
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ4() {

            Console.WriteLine("Dime un valor");
            double valor = double.Parse(PedirType(typeof(double)));

            Console.WriteLine($"El valor que has elegido es: {valor}");
            Console.WriteLine($"El valor que has elegido con 2 decimales es: {valor.ToString("F2")}");
            Console.WriteLine($"El valor que has elegido como moneda es: {valor.ToString("C")}");
            Console.WriteLine($"Comparamos otra cantidad con tu valor por ejemplo 7{(Comparar((int)valor,">",7)?" el precio introducido es mayor":" el precio introucido es menor")}");
            Console.WriteLine("Pulse cualquier tecla para salir"); 
            Console.ReadLine();
        }
        static internal void EJ5() {
            Console.WriteLine("Dime un numero para el descuento (Tiene que ser entre 0 y 1)");
            double descuento = double.Parse(PedirType(typeof(double)));
            while (descuento > 1 || descuento < 0) {
                Console.WriteLine("No puede ser mayor a 1 ni menores a 0");
                descuento = double.Parse(PedirType(typeof(double)));
            }
            Console.WriteLine($"El descuento en pocentaje es de {descuento.ToString("P")}");
            Console.WriteLine($"El precio final de un producto de 15,99 es de:{15.99-(15.99*descuento)}");


            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ6() {

            string producto1 = "col";
            string producto2 = "aguacate";
            string producto3 = "carne";

            double precio1 = 0.85;
            double precio2 = 1.12;
            double precio3 = 3.25;

            Console.WriteLine($"{"Nombre",10:F2} {"Precio",10:F2} {"Cantidad",10:F2} {"Total" ,15:F2}");
            Console.WriteLine($"{producto1,10:F2} {precio1,10:F2} {"5",10:F2} {(precio1*5),15:F2}");
            Console.WriteLine($"{producto2,10:F2} {precio2,10:F2} {"8",10:F2} {(precio2 * 8),15:F2}");
            Console.WriteLine($"{producto3,10:F2} {precio3,10:F2} {"4",10:F2} {(precio3 * 4),15:F2}");
            Console.WriteLine($"Precio total:{(precio1*5)+(precio2*8)+(precio3*4),15:F2}");

            


            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ7() {

            Console.WriteLine("Dime tu nombre");
            string nombre=Console.ReadLine();
            Console.WriteLine("Dime tu salario");
            double salario= double.Parse(PedirType(typeof(double)));
            while (salario < 0) {
                Console.WriteLine("El salario no puede ser negativo");
                salario = double.Parse(PedirType(typeof(double)));
            }

            Console.WriteLine("El nombre el usuario es: {0} y su salario es {1}",nombre,salario);
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ8() {
            Console.Write("Dime el nombre el producto que deseas comprar: ");
            string producto = Console.ReadLine();
            Console.Write("Cuantas unidades deseas comprar: ");
            int cantidad = int.Parse(PedirType(typeof(int)));
            while (cantidad < 0) {
                Console.WriteLine("No puedes comprar menos de 0 unidades");
                cantidad = int.Parse(PedirType(typeof(int)));
            }
            Console.Write("Dime el precio del producto: ");
            double precio = double.Parse(PedirType(typeof(double)));
            while (precio < 0) {
                Console.Write("El precio minimo es 0");
                precio = double.Parse(PedirType(typeof(double)));
            }

            Console.WriteLine($"{"Cantidad",10} {"Producto",10} {"Precio",10} {"TotalProducto",10}");
            Console.WriteLine($"{cantidad,10} {producto,10} {(precio).ToString("C"),10:F2} {(precio*cantidad).ToString("C"),10:F2} ");
            double subtotal = precio * cantidad;
            Console.WriteLine($"{"Subtotal",10} {"IVA",10} {"Total",10}");
            Console.WriteLine($"{subtotal.ToString("C"),10:F2}{"21%",10}{(subtotal+(subtotal*0.21)).ToString("C"),10:F2}");
       
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ9() {

            Console.Write("Dime como te llamas, empleado: ");
            string nombre = Console.ReadLine();
            Console.Write("Cuanto cobras, emplado: ");
            double salarioBase= double.Parse(PedirType(typeof(double)));
            while (salarioBase < 0) {
                Console.Write("No me debes dinero, emplado: ");
                salarioBase = double.Parse(PedirType(typeof(double)));
            }
            Console.Write("Cuanto te retengo, empleado: ");
            double retencion = double.Parse(PedirType(typeof(double)));
            while (retencion < 0 || retencion > 1) {
                Console.Write("No te hagas el listo, empleado. Como maximo es 1 y como minimo 0: ");
                retencion = double.Parse(PedirType(typeof(double)));
            }

            Console.WriteLine($"NombreEmpleado: {nombre,10} \n Salario base: {salarioBase.ToString("C"),10:F2} \n Retencion:{(retencion).ToString("P"),10:F2} \n SalarioNeto:{(salarioBase - (salarioBase * retencion)).ToString("C"),10:F2} \n Dia: {DateTime.Now.ToString("dd/MM/yyyy"),10}");

            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }
        static internal void EJ10() {
            Console.Write("Dime como te llamas: ");
            string nombre = Console.ReadLine();
            Console.Write("Cual es tu edad: ");
            int edad= int.Parse(PedirType(typeof(int)));
            while (edad < 0 || edad > 100) {
                Console.Write("La edad tiene q ser entre 0 y 100: ");
                edad = int.Parse(PedirType(typeof(int)));
            }
            Console.Write("Dime tu salario: ");
            double salario= double.Parse(PedirType(typeof(double)));
            while (salario < 0) {
                Console.Write("El salario no puede ser negativo: ");
                 salario = double.Parse(PedirType(typeof(double)));
            }
            Console.Write("Dime tu pocentaje de ahorro entre 0 y 1: ");
            double ahorro = double.Parse(PedirType(typeof(double)));
            while (ahorro < 0 || ahorro > 1) {
                Console.Write("El ahorro tiene que ser entre 0 y 1: ");
                ahorro = double.Parse(PedirType(typeof(double)));
            }
            Console.Write("Dime tu fecha de nacimiento: ");
            bool fechaNaC = DateTime.TryParse(Console.ReadLine(),out DateTime fecha);
            while(Comparar(edad,"<",(DateTime.Now.Year - fecha.Year))) {
                Console.Write("Tu fecha de nacimiento y tu edad no coinciden, por favor dime tu edad correcta, si todavia no ha sido tu cumpleaños suma un año a tu edad: ");
                edad = int.Parse(PedirType(typeof(int)));
            }

            Console.WriteLine($"El usuario con nombre: {nombre} que tiene:"+" {0} con fecha de nacimiento: "+ fecha.ToString("dd/MM/yyyy")+"  cobra: "+salario.ToString("C")+" ahorra un total de: "+ahorro.ToString("P"),edad);
            Console.WriteLine($"El usuario con nombre {nombre} que tiene {edad}, nacio el {fecha.ToString("dd/MM/yyyy")}  cobra {salario.ToString("C")} y ahorra un total de {ahorro.ToString("P")}");
            Console.WriteLine("Pulse cualquier tecla para salir");
            Console.ReadLine();
        }

        private static string PedirType(Type type) {

            var r = 0;

            if (type == typeof(int)) {
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
        public static bool Comparar(int num, string comparador, int comparacion) {
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
                    if (num == comparacion) {
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

    }
}