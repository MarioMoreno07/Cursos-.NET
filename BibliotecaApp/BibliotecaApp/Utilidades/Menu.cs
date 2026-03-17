using BibliotecaApp.Modelos;
using BibliotecaApp.Servicios;

namespace BibliotecaApp.Utilidades {
    internal class Menu {

        public void MostrarMenu() {
            int opcion = -1;
            var usuarioService  = new UsuarioService();
            var prestamoService = new PrestamoService();
            var bibliotecaService = new BibliotecaService();
            do {
                Console.Clear();
                Console.WriteLine("\n === SISTEMA BIBLIOTECA === ");
                Console.WriteLine(" 1.Agregar libro ");
                Console.WriteLine(" 2.Mostrar libros");
                Console.WriteLine(" 3.Registrar usuario ");
                Console.WriteLine(" 4.Realizar préstamo");
                Console.WriteLine(" 0.Salir ");
                bool esNum = int.TryParse(Console.ReadLine(), out opcion);

                while (!esNum) {
                    Console.WriteLine("Debes e introucir un numero");
                    esNum = int.TryParse(Console.ReadLine(), out opcion);
                }

            switch (opcion) {

                case 1:
                    Console.Write("Cual es el titulo del libro: ");
                    string nombreLibro = Console.ReadLine();
                    Console.Write("Cual es el nombre del autor:");
                    string nombreAutor= Console.ReadLine();
                    Console.Write("Cual es la categoria del libro: ");
                    string nombreCategoria =  Console.ReadLine();
                    Libro libro = new Libro(new Autor(nombreAutor), nombreLibro, new Categoria(nombreCategoria));
                    bibliotecaService.AgregarLibros(libro);
                    Console.WriteLine("Libro agregado con exito");
                    Console.WriteLine("Pulse cualquier tecla para salir");
                    Console.ReadLine();
                    break;
                case 2:
                    bibliotecaService.MostrarLibros();
                    Console.WriteLine("Pulse cualquier tecla para salir");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Write("Cual es tu nombre: ");
                    string nombreUsuario = Console.ReadLine();
                    Console.Write("Cual es tu DNI: ");
                    string dni = Console.ReadLine();
                    Console.WriteLine("Usuario registrado");
                    Console.WriteLine("Pulse cualquier tecla para salir");
                    Console.ReadLine();

                    usuarioService.AgregarUsuario(new Usuario(nombreUsuario, dni));
                    break;
                case 4:
                    Console.Write("Cual es el nombre libro: ");
                    string nombreLibroPrestamo = Console.ReadLine();
                    Console.Write("Cual es tu DNI: ");
                    string dniPrestamo = Console.ReadLine();
                    bool usuarioEncontrado = false;
                    bool libroEncontrado = false;
                    Usuario usuarioPrestamo = null;
                    Libro libroPrestamo = null;

                    for(int i = 0;i<usuarioService.usuarios.Count && !usuarioEncontrado; i++) {
                            if (dniPrestamo == usuarioService.usuarios[i].Dni) {
                                usuarioPrestamo = usuarioService.usuarios[i];
                                usuarioEncontrado = true;
                            } 
                    }
                        
                        for (int i = 0; i < bibliotecaService.libros.Count && !libroEncontrado; i++) {

                            if (nombreLibroPrestamo == bibliotecaService.libros[i].Nombre) {
                                libroPrestamo = bibliotecaService.libros[i];
                                libroEncontrado = true;
                            } 
                        }

                        if (usuarioEncontrado && libroEncontrado) {
                            prestamoService.RealizarPrestamo(usuarioPrestamo, libroPrestamo);

                        } else if (!usuarioEncontrado) {
                            Console.WriteLine("Usuario no encontrado");

                        } else { Console.WriteLine("Libro no encontrado"); }

                            prestamoService.MostrarPrestamos();
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 0:
                        Console.WriteLine("Gracias por usar nuestra bibliteca.");
                        break;
                    default:
                        Console.WriteLine("Numero incorrecto");
                        break;
            }
            } while (opcion != 0 || opcion > 5);
        }
    }
}
