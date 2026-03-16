using BibliotecaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Servicios {
    internal class PrestamoService {
        List<Prestamo> prestamos = [];

        public void RealizarPrestamo(Usuario usuario , Libro libro) {

            if (libro.Disponible) {

                prestamos.Add(new Prestamo(libro,usuario));
                libro.Disponible = false;
            } else {
                Console.WriteLine("El libro no esta disponible");
            }
            
        }

        public void MostrarPrestamos() {
            foreach (Prestamo prestamo in prestamos) {
                Console.WriteLine($"El usuario {prestamo.Usuario.Nombre} ha sacado el libro {prestamo.Libro.Nombre} en la fecha {prestamo.fechaPrestamo}");
            }
            }
    }
}
