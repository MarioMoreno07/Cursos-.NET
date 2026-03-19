using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Modelos {
    internal class Inscripcion {

        public string EmailAlumno { get; set; }
        public string NombreCurso { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public DateTime FechaLimiteEntrega { get; set; }

        public Inscripcion(string emailAlumno , string nombreCurso) {
        
            EmailAlumno = emailAlumno;
            NombreCurso = nombreCurso;
            FechaInscripcion = DateTime.Now;
            FechaLimiteEntrega = DateTime.Now.AddDays(15);
        }
    }
}
