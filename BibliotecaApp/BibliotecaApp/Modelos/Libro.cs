using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Modelos {
    internal class Libro {

        public Autor Autor;
        public string Nombre {  get; set; }
        public Categoria Categoria { get; set; }
        public bool Disponible = true;

        public Libro(Autor autor, string nombre , Categoria categoria) {
            this.Autor = autor;
            this.Nombre = nombre;
            this.Categoria = categoria;
        
        }
    }
}
