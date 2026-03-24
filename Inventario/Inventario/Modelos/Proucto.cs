using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Modelos {
    internal class Proucto {

        public  string Codigo {  get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Stock {  get; set; }

        public Proucto(string codigo, string nombre , string categoria , double precio , int stock) {

            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Stock = stock;

        
        }

    }
}
