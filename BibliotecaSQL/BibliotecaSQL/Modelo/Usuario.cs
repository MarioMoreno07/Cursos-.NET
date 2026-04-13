using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSQL.Modelo {
    public class Usuario {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Dni {  get; set; }
        public DateTime FechaAlta { get; set; } 

    }
}
