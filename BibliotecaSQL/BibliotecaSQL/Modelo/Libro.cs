using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSQL.Modelo {
    public  class Libro {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public bool Disponible { get; set; }
        public int Anio { get; set; }
        public string Categoria {  get; set; }

        public Libro(int id , string titulo , string autor , string categoria,int anio, bool disponible ) {

            Id = id;
            Titulo = titulo;
            Autor = autor;
            Disponible = disponible;
            Anio = anio;
            Categoria = categoria;
        }
    }
}
