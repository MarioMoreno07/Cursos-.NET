using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEFCore.Modelos {
    public class Prestamo {

        public int Id { get; set; }
        public int LibroId { get; set; }
        public Libro Libro { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public  DateTime FechaDevolucion { get; set; }
        public  DateTime? FechaDevolucionReal { get; set; } 

       public Prestamo(int libroId, int usuarioId) {
        
            LibroId = libroId;
            UsuarioId = usuarioId;
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = DateTime.Now.AddDays(15);
            
        }

        public override string ToString() {
            return $"El prestamo con id {Id}, con titulo de libro {Libro.Titulo}, ha sido sacado por el usuario {Usuario.Nombre} , la fecha prevista de devolucion es" +
                $"la fecha {FechaDevolucion.ToString("dd-MM-yyyy")} y actualmente se encuentra {(EstaActivo() ? "Activo": "Devuelto") }";
        }

        public  bool EstaActivo() {
            if(FechaDevolucionReal is null) {
                return true;
            }
            
            return false;
        }

        public  bool EstaVencido() {
            bool s =false;
            if(EstaActivo() && DateTime.Now > FechaDevolucion) {
                s = true;
            } 

                return s;
        }

    }
}
