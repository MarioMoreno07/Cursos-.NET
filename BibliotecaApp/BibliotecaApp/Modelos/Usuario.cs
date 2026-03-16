using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Modelos {
    internal class Usuario {
        public string Nombre {  get; set; }
        public string Dni {  get; set; }

        public Usuario(string nombre, string dni) { 
            Dni = dni;
            Nombre = nombre;
        }
    }
}
