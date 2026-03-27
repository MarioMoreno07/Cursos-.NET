using BibliotecaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Servicios {
    public class PrestamoService {
        public List<Prestamo> prestamos = new List<Prestamo>();

        public bool RealizarPrestamo(Usuario usuario, Libro libro) {

            bool r = false;

            if (usuario == null) {
                throw new ArgumentNullException("No pasa al usuario");
            } else if (libro == null) {
                throw new ArgumentNullException("No pasa el libro");
            } else if (libro.Disponible) {

                prestamos.Add(new Prestamo(libro, usuario));
                libro.Disponible = false;
                r = true;
            } else {
                throw new InvalidOperationException("El libro ya lo tiene otra persona");
            }
            return r;
        }

        public void MostrarPrestamos() {
            if (prestamos.Count == 0) {
                throw new NullReferenceException("No hay prestamos");
            } else {
                foreach (Prestamo prestamo in prestamos) {
                    Console.WriteLine($"El usuario {prestamo.Usuario.Nombre} ha sacado el libro {prestamo.Libro.Nombre} en la fecha {prestamo.fechaPrestamo}");
                }
            }
        }

        public bool MarcarComoNoDisponible(Libro libro) {
            bool r = false;
            if(libro == null) {
                throw new ArgumentNullException("El libro esta vacio");
            } else {
                libro.Disponible = !libro.Disponible;
                r = true;
            }

                return r;
        }

        public List<Prestamo> MostrarPrestamosVencidos() {
            List<Prestamo> prestamosAcabados = new List<Prestamo> ();

            prestamosAcabados = prestamos.Where(prestamo => prestamo .fechaFinPrestamo < DateTime.Now).ToList();

            if (prestamosAcabados.Count == 0) {
                throw new NullReferenceException("No hay prestamos vencidos");
            }

            return prestamosAcabados;
        }

        public bool devolverPrestamo(Libro libro) {
            bool r = false;
            if (libro == null) {
                throw new ArgumentNullException("El libro no puedes ser nulo");
            }else if (libro.Disponible){
                throw new ArgumentException("El libro ya esta disponible");
            } else {
                Prestamo p = prestamos.Where(pre => pre.Libro.Nombre == libro.Nombre).FirstOrDefault();
                if(p == null) {
                    throw new ArgumentNullException("Ese prestamo ya esta quitado");
                }
                prestamos.Remove(p);
                libro.Disponible = true;
                r = true;
                
            }


                return r;
        }


        public List<Prestamo> prestamosVencidos() {
            List<Prestamo> prestamosVencidos = new List<Prestamo>();
            prestamosVencidos = prestamos.Where(prestamos => prestamos.fechaFinPrestamo < DateTime.Now).ToList();

            if (prestamosVencidos.Count < 0) {
                throw new ArgumentNullException("La lista esta vacia");
            }

            return prestamosVencidos;
        }

    }
}
