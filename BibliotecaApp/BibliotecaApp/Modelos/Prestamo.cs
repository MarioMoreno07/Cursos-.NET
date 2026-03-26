using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Modelos {
    public class Prestamo {

        public Libro Libro { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime fechaPrestamo {  get; set; }
        public DateTime fechaFinPrestamo { get; set; }

        public Prestamo(Libro libro , Usuario usuario) {
               Libro = libro;
               Usuario = usuario;
            fechaPrestamo = DateTime.Now;
            fechaFinPrestamo = DateTime.Now.AddDays(20);
        }
    }
}
