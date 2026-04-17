using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEFCore.Modelos {
    public class Usuario {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Dni {  get; set; }
        public DateTime FechaAlta {  get; set; }

        public ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        public override string ToString() {
            return $"El usuario con id {Id}, se llama {Nombre} y tiene el dni {Dni}. Fue dado de alta {FechaAlta.ToString("dd-MM-yyyy")}";
        }
    }
}
