using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotcaSwagger.Modelos {
    public class Libro {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public int Anio { get; set; }
        public bool Disponible { get; set; }

        public ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();

        public override string ToString() {
            return $"El libro con id {Id}, tiene de titulo {Titulo}, fue escrito por {Autor}, se encuntra en la categoria de {Categoria} y fue escrito en el año {Anio}.Actualmente" +
                $"este libro se encuentra disponible: {Disponible} ";
        }
    }
}
