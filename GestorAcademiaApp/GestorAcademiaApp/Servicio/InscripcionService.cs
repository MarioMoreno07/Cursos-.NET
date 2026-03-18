using GestorAcademiaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Servicio {
    internal class InscripcionService {
       

        public List<Inscripcion> inscripcions = [];
        public void InscribirAlumno(Inscripcion inscripcion, AlumnoService alumService , CursoService1 cursoService) {

            if (ValidarAlumno(inscripcion,alumService) && ValidarCurso(inscripcion,cursoService)) {

                if (inscripcion.FechaLimiteEntrega > DateTime.Now) {
                    inscripcions.Add(inscripcion);
                    Console.WriteLine("Usuario inscrito");
                } else { Console.WriteLine("La fecha ha pasado");
                }

            } else {
                Console.WriteLine("El alumno o el curso no existe");
            }
        }

        public void MostrarInscripciones() {
            foreach(Inscripcion inscripcion in inscripcions) {
                Console.WriteLine($"El alumno {inscripcion.EmailAlumno}, se ha inscrito en el curso: {inscripcion.NombreCurso}");
            }
        }

        public bool ValidarAlumno(Inscripcion inscripcion, AlumnoService alumnoService) {
            bool r = false;
            bool encontrado = false;

           

            for ( int i = 0; i < alumnoService.alumnoList.Count && !encontrado; i++) {
                if (alumnoService.alumnoList.ElementAt(i).Email == inscripcion.EmailAlumno) {
                    r = true;
                    encontrado = true;
                    
                }
            }
           
            return r;
        }
        public bool ValidarCurso(Inscripcion inscripcion,CursoService1 cursoService) {
            bool r = false;
            bool encontrado = false;

            

            for (int i = 0; i < cursoService.cursos.Count && !encontrado; i++) {
                if (cursoService.cursos.ElementAt(i).Nombre.Contains(inscripcion.NombreCurso)) {
                    r = true;
                    encontrado = true;
                    
                }
            }

            return r;
        }

        }
}
