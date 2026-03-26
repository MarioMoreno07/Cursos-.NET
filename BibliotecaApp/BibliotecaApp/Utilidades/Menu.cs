using BibliotecaApp.Modelos;
using BibliotecaApp.Servicios;

namespace BibliotecaApp.Utilidades {
    internal class Menu {

        public void MostrarMenu() {
            int opcion = -1;
            var usuarioService = new UsuarioService();
            var prestamoService = new PrestamoService();
            var bibliotecaService = new BibliotecaService();
            var persistenciaService = new PersistenciaService();

            try {
                persistenciaService.LeerPersistenciaUsuarios(usuarioService);
                persistenciaService.LeerPersistenciaLibros(bibliotecaService);
                persistenciaService.LeerPersistenciaPrestamos(prestamoService);
            } catch(NullReferenceException e) {
                Console.WriteLine(e.Message);
            }
           
             
            do {
                Console.Clear();
                Console.WriteLine("\n === SISTEMA BIBLIOTECA === ");
                Console.WriteLine(" 1.Agregar libro ");
                Console.WriteLine(" 2.Mostrar libros");
                Console.WriteLine(" 3.Buscar libro por titulo");
                Console.WriteLine(" 4.Registrar usuario ");
                Console.WriteLine(" 5.Mostrar usuario");
                Console.WriteLine(" 6.Buscar usuario por DNI");
                Console.WriteLine(" 7.Realizar préstamo");
                Console.WriteLine(" 8.Devolver libro");
                Console.WriteLine(" 9.Mostrar prestamos");
                Console.WriteLine(" 0.Salir ");
                bool esNum = int.TryParse(Console.ReadLine(), out opcion);

                while (!esNum) {
                    Console.WriteLine("Debes e introucir un numero");
                    esNum = int.TryParse(Console.ReadLine(), out opcion);
                }

                switch (opcion) {

                    case 1:
                        try {
                            Console.WriteLine("Cual es el titulo del libro");
                            string tituloLibro = Console.ReadLine();
                            Console.WriteLine("Dime el nombre del autor");
                            string nombreAutor = Console.ReadLine();
                            Console.WriteLine("Dime la categoria del libro");
                            string categoriaLibro = Console.ReadLine();

                            Autor autor = new Autor(nombreAutor);
                            Categoria categoria = new Categoria(categoriaLibro);

                            Libro libro = new Libro(autor, tituloLibro, categoria);

                           bibliotecaService.AgregarLibros(libro);

                        }catch(Exception ex) {
                            if (ex is DuplicateWaitObjectException || ex is ArgumentNullException) {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 2:
                        try {
                            bibliotecaService.MostrarLibros();
                        } catch (NullReferenceException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 3:
                        try {
                            Libro libro=null;
                            
                            Console.WriteLine("Dime el titulo del libro para busacarlo");
                            string tituloLibroBuscar = Console.ReadLine();
                           libro= bibliotecaService.buscarLibroPorTitulo(tituloLibroBuscar);
                            Console.WriteLine($"El libro es: {libro.Nombre} y su disponibilidad es: {(libro.Disponible?"Disponible":"No disponible")} ");
                        } catch(Exception ex) { 
                            if (ex is NullReferenceException || ex is ArgumentNullException) {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 4:
                        try {
                            Console.WriteLine("Dime el nombre del usuario");
                            string nombreUser = Console.ReadLine();
                            Console.WriteLine("Dime el dni del usuario");
                            string dniUser = Console.ReadLine();
                            Usuario usuario = new Usuario(nombreUser,dniUser);
                            usuarioService.AgregarUsuario(usuario);
                        }catch(Exception ex) {
                            if (ex is DuplicateWaitObjectException || ex is ArgumentNullException) {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 5:
                        try {
                            usuarioService.MostrarUsuarios();
                        } catch (NullReferenceException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 6:
                        try {
                            Usuario user = null;
                            Console.WriteLine("Digame el dni del usuario que deseas buscar");
                            string dniUserBuscar = Console.ReadLine();
                           user= usuarioService.BuscarUsuarioDni(dniUserBuscar);
                            Console.WriteLine("El usuario con ese dni es: "+user.Nombre);
                        } catch (Exception ex) {
                            if(ex is NullReferenceException || ex is ArgumentNullException) {
                                Console.WriteLine(ex.Message);
                            }
                        }

                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;

                    case 7:
                        try {
                             
                            Console.WriteLine("Digame el titulo del libro");
                            string tituloPrestamo=Console.ReadLine();
                            Console.WriteLine("Digame su dni");
                            string dniPrestamo = Console.ReadLine();
                            bool r = prestamoService.RealizarPrestamo(usuarioService.BuscarUsuarioDni(dniPrestamo), bibliotecaService.buscarLibroPorTitulo(tituloPrestamo));
                       
                                Console.WriteLine($"{(r?"Prestamo realizado":"Prestamos no realizao")}");

                        } catch(Exception ex) {
                            if (ex is DuplicateWaitObjectException || ex is ArgumentNullException) {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 8:
                        try {

                        
                        Console.WriteLine("Digame el titulo del libro");
                        string tituloDevolver = Console.ReadLine();

                        bool d = prestamoService.devolverPrestamo(bibliotecaService.buscarLibroPorTitulo(tituloDevolver));
                        Console.WriteLine($"{(d?"Libro devuelto con exito":"Pase otro dia para realizar la devolucion")}");
                        } catch(Exception ex) {
                            if (ex is ArgumentException || ex is ArgumentNullException) {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 9:
                        try {
                            prestamoService.MostrarPrestamos();
                        } catch (NullReferenceException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 0:
                        try {
                            persistenciaService.LanzarPersistenciaUsuario(usuarioService);
                            persistenciaService.LanzarPersistenciaLibro(bibliotecaService);
                            persistenciaService.LanzarPersistenciaPrestamos(prestamoService);
                        } catch(NullReferenceException e) {
                            Console.WriteLine(e.Message);
                        }
                        
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
