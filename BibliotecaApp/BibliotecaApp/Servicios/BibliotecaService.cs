using BibliotecaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Servicios {
    public class BibliotecaService {

        public List<Libro> libros = new List<Libro>();

        public bool AgregarLibros(Libro libro) {
            bool r = false;

            if (libro == null) {

                throw new ArgumentNullException("El libro esta vacio");
            }else if (libros.Where(lib => lib.Nombre.Equals(libro.Nombre)).Count() >0 ) {

                throw new DuplicateWaitObjectException("El libro ya existe");
            } else if (libro.Nombre.Equals(null)) {
                throw new ArgumentNullException("El titulo del libro esta vacio");
            }else if(string.IsNullOrEmpty(libro.Categoria.Nombre)) {
                throw new ArgumentNullException("La categoria del libro esta vacio");
            }else if(string.IsNullOrEmpty(libro.Autor.Nombre)) {
                Autor autorDes = new Autor("Desconocido");
                libro.Autor = autorDes;
                libros.Add(libro);
                r = true;
                Console.WriteLine("Libro añadido");
            }
            else {
                libros.Add(libro);
                r = true;
                Console.WriteLine("Libro añadido");
            }


                return r;
        }

        public void MostrarLibros() {
            if (libros.Count == 0) {
                throw new NullReferenceException("No hay libros que mostrar");
            } else {
                foreach (Libro libro in libros) {
                    Console.WriteLine($"El libro con el titulo {libro.Nombre}, esta escrito por el autor {libro.Autor.Nombre} y se encuentra en la categoria {libro.Categoria.Nombre}");
                }
               
            }
        }


        public Libro buscarLibroPorTitulo(string titulo) {
            Libro libro = null;

            if(titulo.Equals(null)){
                throw new ArgumentNullException("El titulo del libro no puede estar vacio");
            }else if (libros.Where(lib => lib.Nombre.Equals(titulo)).Count() == 0) {
                throw new NullReferenceException("El libro no existe");
            } else {
                libro = libros.Where(lib => lib.Nombre.Equals(titulo)).FirstOrDefault();
                if (libro == null) {
                    throw new NullReferenceException("No hay libro");
                }
            }
                return libro;
        }
    }
}
