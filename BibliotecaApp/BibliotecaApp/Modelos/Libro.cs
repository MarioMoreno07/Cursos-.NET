using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Modelos {
    public class Libro {

        public Autor Autor { get; set; }
        public string Nombre {  get; set; }
        public Categoria Categoria { get; set; }
        public bool Disponible {  get; set; }

        public Libro(Autor autor, string nombre , Categoria categoria) {
            this.Autor = autor;
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.Disponible = true;
        
        }
    }
}
