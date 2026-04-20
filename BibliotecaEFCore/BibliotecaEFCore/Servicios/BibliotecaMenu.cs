using BibliotecaEFCore.Data;
using BibliotecaEFCore.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
                        try {
                            ListarLibros();
                        } catch(NullReferenceException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        
                        Console.WriteLine("Pulse para salir"); 
                        Console.ReadLine(); 
                        break;
                    case 2:
                        try {
                            InsertarLibro();
                        } catch(StackOverflowException ex) {
                           Console.WriteLine(ex.Message);
                        }
                       
                        Console.WriteLine("Pulse para salir"); 
                        Console.ReadLine(); 
                        break;
                     case 3:
                        try {
                            ListarUsuarios();
                        } catch(NullReferenceException ex){
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 4:
                        try {
                            AñadirUsuario();
                        }catch(Exception ex) {
                            if(ex is StackOverflowException || ex is DuplicateWaitObjectException) {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        Console.WriteLine("Pulse para salir"); 
                        Console.ReadLine(); 
                        break;
                    case 5:
                        try {
                            RealizarPrestamo();
                        }catch(Exception ex) {
                            if(ex is NullReferenceException || ex is ArgumentException) {
                                Console.WriteLine(ex.Message);
                            }
                        }
                         Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 6:
                        try {
                            DevolverLibro();
                        }catch(Exception ex) {
                            if (ex is NullReferenceException || ex is ArgumentException) {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        
                        
                        Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                     case 7: EstadoPrestamos(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                     case 8: Estadisticas(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;

                }

            } while (opcion != 9);
        }

        public void ListarLibros() {
            

          var libros= _db.Libros
            .AsNoTracking()
            .OrderBy(l => l.Titulo)
            .ToList();

            if (libros.Count() > 0) {
                foreach (Libro libro in libros) {
                    Console.WriteLine(libro.ToString());
                }
            } else {
                throw new NullReferenceException("La lista esta vacia");
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


            while (tituloLibroAnadir.IsNullOrEmpty()) {
                Console.WriteLine("Dime el titulo del libro");
                 tituloLibroAnadir = Console.ReadLine();
            }
            while (autorLibroAnadir.IsNullOrEmpty()) {
                Console.WriteLine("Dime el autor del libro");
                 autorLibroAnadir = Console.ReadLine();
            }
            while(categoriaLibroAnadir.IsNullOrEmpty()) {
                Console.WriteLine("Dime la categoria autor del libro");
                categoriaLibroAnadir = Console.ReadLine();
            }
            if (tituloLibroAnadir.Length > 200 || autorLibroAnadir.Length > 150 || categoriaLibroAnadir.Length > 100) {
                throw new StackOverflowException("Titulo no puede tener mas de 200 caracteres , autor no mas de 150 y categoria no mas de 100");
            }
                Libro libro = new Libro(tituloLibroAnadir,autorLibroAnadir,categoriaLibroAnadir,anio);
                _db.Libros.Add(libro);
                _db.SaveChanges();
            Console.WriteLine("Libro añadido con exito");
            }
        
        public void ListarUsuarios() {
            var usuarios = _db.Usuarios
            .AsNoTracking()
            .OrderBy(u => u.Nombre)
            .ToList();

            if (usuarios.Count > 0) {
                foreach (Usuario usuario in usuarios) {
                    Console.WriteLine(usuario.ToString());
                }
            } else {
                throw new NullReferenceException("La lista esta vacia");
            }
            
        }

        public void AñadirUsuario() {
            Console.WriteLine("Como se llama");
            string nombreUsuarioAnadir = Console.ReadLine();
            Console.WriteLine("Digame su Dni");
            string dniUsuarioAndir = Console.ReadLine();
            while (nombreUsuarioAnadir.IsNullOrEmpty()) {
                Console.WriteLine("Como se llama");
                nombreUsuarioAnadir = Console.ReadLine() ;
            }
             while(dniUsuarioAndir.IsNullOrEmpty() ) {
                Console.WriteLine("Digame su Dni");
                dniUsuarioAndir =Console.ReadLine() ;
            }
             if(nombreUsuarioAnadir.Length > 150) {
                throw new StackOverflowException("El nombre del usuario no puede ser superior a 150");
            }
             if(dniUsuarioAndir.Length > 20) {
                throw new StackOverflowException("El dni del usuario no puede ser superior a 20");
            }

            if(_db.Usuarios.Any(u => u.Dni.Equals(dniUsuarioAndir))) {
                throw new DuplicateWaitObjectException("Este usuario ya se encuentra registrado");
            } else {
                Usuario usuario = new Usuario(nombreUsuarioAnadir,dniUsuarioAndir);
                _db.Usuarios.Add(usuario);
                _db.SaveChanges();
                Console.WriteLine("Usuario añadido con exito");
            }
        }

        public void RealizarPrestamo() {
            Console.WriteLine("Dime el id del libro");
            bool idLibro = int.TryParse(Console.ReadLine(), out int idLibroPrestamo);
            Console.WriteLine("Dime el id del usuario");
            bool idUsuario = int.TryParse(Console.ReadLine(), out int idUsuarioPrestamo);

            while (!idLibro) {
                Console.WriteLine("Dime el id del libro");
                 idLibro = int.TryParse(Console.ReadLine(), out  idLibroPrestamo);
            }
            while (!idUsuario) {
                Console.WriteLine("Dime el id del usuario");
                 idUsuario = int.TryParse(Console.ReadLine(), out  idUsuarioPrestamo);
            }

            var libro = _db.Libros
                .AsNoTracking()
                .Where(l => l.Id.Equals(idLibroPrestamo))
                .FirstOrDefault();
           if(libro == null) {
                throw new NullReferenceException("No existe un libro con esa id");
           } else if(!libro.Disponible) {
                throw new ArgumentException("Este libro ya esta prestado");
           }

            var usuario = _db.Usuarios
                 .AsNoTracking()
                 .Where(u => u.Id.Equals(idUsuarioPrestamo))
                 .FirstOrDefault();

            if (usuario == null) { 
                throw new NullReferenceException("El usuario con esa Id no existe");
            } else {
                Prestamo prestamo = new Prestamo(idLibroPrestamo, idUsuarioPrestamo);
                libro.Disponible = !libro.Disponible;
               _db.Libros.Update(libro);

                _db.Prestamos.Add(prestamo);

                _db.SaveChanges();

            }

        }

        public void DevolverLibro() {
            Console.WriteLine("Cual es el id del libro");
            bool libroDevolver = int.TryParse(Console.ReadLine(), out int idLibroDevolver);

            while (!libroDevolver) {
                Console.WriteLine("Cual es el id del libro");
                 libroDevolver = int.TryParse(Console.ReadLine(), out  idLibroDevolver);
            }
            var libro = _db.Libros
              .AsNoTracking()
              .Where(l => l.Id.Equals(idLibroDevolver))
              .FirstOrDefault();
            if (libro == null) {
                throw new NullReferenceException("No existe libro con esa id");
            } else {

            var prestamo = _db.Prestamos
            .AsNoTracking()
            .Where(p => p.LibroId.Equals(idLibroDevolver) && p.FechaDevolucionReal == null)
            .FirstOrDefault();

                if (prestamo == null) {
                    throw new ArgumentException("Ese libro ya esta devuelto o no existe el prestamo");
                } else {
                    prestamo.FechaDevolucionReal = DateTime.Now;
                    libro.Disponible = !libro.Disponible;
                    _db.Prestamos.Update(prestamo);
                    _db.Libros.Update(libro);
                    _db.SaveChanges();
                    Console.WriteLine("Libo devuelto con exito");

                }
            }

        

        }

        public void EstadoPrestamos() {
           var prestamos=  _db.Prestamos
                .Include(p => p.Libro)
                .Include(p => p.Usuario)
                .AsNoTracking()
                .OrderByDescending(p => p.FechaPrestamo)
                .ToList();

            foreach(Prestamo prestamo in prestamos) {
                Console.WriteLine(prestamo.ToString());
                if (prestamo.EstaVencido()) {
                    Console.WriteLine($"El libro esta vencido por: {(DateTime.Now - prestamo.FechaDevolucion).Days}");
                }
            }
        }

        public void Estadisticas() {
            Console.WriteLine($"El total de libros es de : {_db.Libros.Count()}");
            Console.WriteLine($"El total de libros disponibles es de: {_db.Libros.Count(l => l.Disponible)}");
            Console.WriteLine($"Los libros prestados son: {_db.Libros.Count() - _db.Libros.Count(l => l.Disponible)}");
           var mejoresCategoras=  _db.Libros
            .GroupBy(l => l.Categoria)
            .Select(g => new { Categoria = g.Key, Total = g.Count() })
            .OrderByDescending(x => x.Total)
            .Take(5)
            .ToList();
            Console.WriteLine($"Las mejores categorias son: ");
            foreach(var categoria in mejoresCategoras) {
                Console.Write(categoria + "\n");
            }
            Console.WriteLine($"Prestamos activos: {_db.Prestamos.Count(p => p.FechaDevolucionReal == null)}");
            Console.WriteLine($"Prestamos vencidos: {_db.Prestamos.Count(p => p.FechaDevolucionReal == null && DateTime.Now > p.FechaDevolucion)}");
        }
    }
}
