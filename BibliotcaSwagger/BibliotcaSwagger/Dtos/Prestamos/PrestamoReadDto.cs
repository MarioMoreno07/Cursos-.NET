using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotcaSwagger.Dtos.Prestamos {
    public class PrestamoReadDto {

        public int Id { get; set; }
        public int LibroId { get; set; }
        public int UsuaioId { get; set; }
        public string NombreUsuario { get; set; }
        public string TituloLibro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion {  get; set; }
        public DateTime? FechaDevolucionReal { get; set; }
        public bool Activo { get; set; }
        public bool Vencido { get; set; }
       
    }
}
