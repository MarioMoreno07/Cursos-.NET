using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Modelos {
    internal class Alumno {
        internal string Nombre { get; set; }
        internal string Email { get; set; }

        internal int[] Notas = new int[5];

        public Alumno(string nombre, string email,int[] notas) {
        
            Nombre = nombre;
            Email = email;
            Notas = notas;
        }
    }
}
