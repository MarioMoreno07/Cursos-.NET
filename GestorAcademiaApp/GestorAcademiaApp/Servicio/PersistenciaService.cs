using GestorAcademiaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Servicio {
    internal class PersistenciaService {

        public void LanzarPersistencia(CursoService1 cursoService1, AlumnoService alumnoService, InscripcionService inscripcionService) {

            string jsonCurso = JsonSerializer.Serialize(cursoService1.cursos);
            File.WriteAllText("Cursos.json", jsonCurso);
            string jsonAlumno = JsonSerializer.Serialize(alumnoService.alumnoList);
            File.WriteAllText("Alumno.json", jsonAlumno);
            string jsonInscripcion = JsonSerializer.Serialize(inscripcionService.inscripcions);
            File.WriteAllText("Inscripciones.json", jsonInscripcion);

        }

        public void LeerPersistencia(CursoService1 cursoService1, AlumnoService alumnoService, InscripcionService inscripcionService) {

            if (File.Exists("Cursos.json")) {
                
                List<Curso> cursos = JsonSerializer.Deserialize<List<Curso>>(File.ReadAllText("Cursos.json")) ?? new List<Curso>();
                cursoService1.cursos = cursos;
            }
            if (File.Exists("Alumno.json")) {
                List<Alumno> alumnos = JsonSerializer.Deserialize<List<Alumno>>(File.ReadAllText("Alumno.json")) ?? new List<Alumno>();
                alumnoService.alumnoList = alumnos;
            }
            if (File.Exists("Inscripciones.json")) {
               
                List<Inscripcion> inscripciones = JsonSerializer.Deserialize<List<Inscripcion>>(File.ReadAllText("Inscripciones.json")) ?? new List<Inscripcion>();
                inscripcionService.inscripcions = inscripciones;
            }
        }
    }
}
