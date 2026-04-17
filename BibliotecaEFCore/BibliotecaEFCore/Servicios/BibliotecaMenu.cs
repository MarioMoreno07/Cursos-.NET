using BibliotecaEFCore.Data;
using BibliotecaEFCore.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEFCore.Servicios {
    public class BibliotecaMenu {

        private readonly BibliotecaDbContext _db;
        public BibliotecaMenu(BibliotecaDbContext db) {

            _db = db;
        }

        public void Iniciar() {
            int opcion;
            do {
                Console.Clear();
                Console.WriteLine("\n=== BIBLIOTECA SQL SERVER ===");
                Console.WriteLine("1. Listar Libros");
                Console.WriteLine("2. Insertar Libro");
                Console.WriteLine("3. Listar Usuario");
                Console.WriteLine("4. Añadir Usuario");
                Console.WriteLine("5. Realizar prestamo ");
                Console.WriteLine("6. Devolver libro");
                Console.WriteLine("7. Préstamos activos/vencidos");
                Console.WriteLine("8.Estadísticas (LINQ)");
                Console.WriteLine("9. Salir");
                Console.Write("Opción: ");

                while (!int.TryParse(Console.ReadLine(), out opcion)) {
                    Console.Write("Opción válida: ");
                }

                switch (opcion) {
                    case 1: 
                        ListarLibros(); 
                        Console.WriteLine("Pulse para salir"); 
                        Console.ReadLine(); 
                        break;
                    case 2:
                        try {
                            InsertarLibro();
                        } catch(NullReferenceException ex) {
                           Console.WriteLine(ex.Message);
                        }
                       
                        Console.WriteLine("Pulse para salir"); 
                        Console.ReadLine(); 
                        break;
                   // case 3: ListarUsuarios(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                   // case 4: AñadirUsuario(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                   // case 5: RealizarPrestamo(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                   // case 6: DevolverLibro(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                   // case 7: PréstamosActivos/Vencidos(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                   // case 8: Estadísticas(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;

                }

            } while (opcion != 9);
        }

        public void ListarLibros() {
            

          var libros= _db.Libros
            .AsNoTracking()
            .OrderBy(l => l.Titulo)
            .ToList();

            foreach (var libro in libros) { 
                libro.ToString();
            }
        }

        public void InsertarLibro() {
            Console.WriteLine("Dime el titulo del libro");
            string tituloLibroAnadir = Console.ReadLine();
            Console.WriteLine("Dime el autor del libro");
            string autorLibroAnadir = Console.ReadLine();
            Console.WriteLine("Dime la categoria autor del libro");
            string categoriaLibroAnadir = Console.ReadLine();
            Console.WriteLine("En que año se publico");
            bool parse = int.TryParse(Console.ReadLine(), out int anio);    

            if(tituloLibroAnadir .Equals(null) || autorLibroAnadir.Equals(null) || categoriaLibroAnadir.Equals(null)) {
                throw new NullReferenceException("Ni el titulo ni el autor  ni la categoria puede ser nulos");
            } else {
                Libro libro = new Libro(tituloLibroAnadir,autorLibroAnadir,categoriaLibroAnadir,anio);
                _db.Libros.Add(libro);
                _db.SaveChanges();
            }
        }
    }
}
