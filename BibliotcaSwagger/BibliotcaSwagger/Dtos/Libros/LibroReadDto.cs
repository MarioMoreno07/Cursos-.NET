using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotcaSwagger.Dtos.Libros {
    public class LibroReadDto {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public string Categoria { get; set; }
        public int Anio { get; set; }
        public bool Disponible { get; set; }
    }
}
