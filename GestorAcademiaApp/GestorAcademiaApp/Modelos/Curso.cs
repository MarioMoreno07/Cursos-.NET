using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Modelos {
    internal class Curso {

        internal string Nombre { get; set; }
        internal int NumHoras { get; set; }

        public Curso(string nombre , int numHoras) {
            Nombre = nombre;
            NumHoras = numHoras;
        }
    }
}
