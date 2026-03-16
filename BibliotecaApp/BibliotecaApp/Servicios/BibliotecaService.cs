using BibliotecaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Servicios {
    internal class BibliotecaService {

        internal List<Libro> libros = [];

        public void AgregarLibros(Libro libro) {

            libros.Add(libro);

        }

        public void MostrarLibros() {
            foreach (Libro libro in libros) {
                Console.WriteLine(libro.Nombre);
            }
        }
    }
}
