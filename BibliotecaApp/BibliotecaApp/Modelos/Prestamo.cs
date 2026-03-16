using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Modelos {
    internal class Prestamo {

        public Libro Libro;
        public Usuario Usuario;
        public DateTime fechaPrestamo = DateTime.Now;

        public Prestamo(Libro libro , Usuario usuario) {
               Libro = libro;
               Usuario = usuario;
        }
    }
}
