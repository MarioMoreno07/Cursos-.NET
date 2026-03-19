using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Modelos {
    internal class Alumno {
        public string Nombre { get; set; }
        public string Email { get; set; }

        public int[] Notas { get; set; } = new int[5];

        public Alumno(string nombre, string email,int[] notas) {
        
            Nombre = nombre;
            Email = email;
            Notas = notas;
        }
    }
}
