using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Modelos {
    internal class Inscripcion {

        internal string EmailAlumno { get; set; }
        internal string NombreCurso { get; set; }
        internal DateTime FechaInscripcion;
        internal DateTime FechaLimiteEntrega;

        public Inscripcion(string emailAlumno , string nombreCurso) {
        
            EmailAlumno = emailAlumno;
            NombreCurso = nombreCurso;
            FechaInscripcion = DateTime.Now; ;
            FechaLimiteEntrega = DateTime.Now.AddDays(15);
        }
    }
}
