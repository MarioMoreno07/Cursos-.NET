using GestorAcademiaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Servicio {
    internal class ReporteService {

        public void AnalizarNotas(Alumno alumno) {

            Console.WriteLine("La nota media del alumno " + alumno.Nombre + " es: "+Math.Round(alumno.Notas.Average()));
            Console.WriteLine("La nota mas alta del alumno " + alumno.Nombre+ " es: " + alumno.Notas.Max());
            Console.WriteLine("La nota baja del alumno " + alumno.Nombre + " es:"  + alumno.Notas.Min());

        }

        public void EstadisticasGenerales(AlumnoService alumnoService) { 
        
            foreach(Alumno al in alumnoService.alumnoList) {
                Console.WriteLine($"La nota media de {al.Nombre} es de: {Math.Round(al.Notas.Average())} ");
            }
            Console.WriteLine($"La nota media ordenada de mayor a menor es: ");
            List<Alumno> listaMedia = alumnoService.alumnoList.OrderByDescending(alumno => alumno.Notas.Average()).ToList();
            foreach (Alumno al in listaMedia) {

                Console.WriteLine($"El alumno {al.Nombre}, tiene una media de: {Math.Round(al.Notas.Average())}"); 
            }
            Console.WriteLine("La lista de aprobados es: ");
            foreach (Alumno al in listaMedia) {
                if((al.Notas.Average()) > 5) {
                    Console.WriteLine($"El alumno {al.Nombre} ha apobado");
                }
            }

        }

        public void InscripcionesVencidas(InscripcionService inscripcionService) {

            
            List<Inscripcion> inscripcionesVencidas = inscripcionService.inscripcions.Where(inscripcion => inscripcion.FechaLimiteEntrega < DateTime.Now ).ToList();
            if (inscripcionesVencidas.Count > 0) {
                Console.WriteLine("Las inscripciones vencidas son: ");
                foreach (Inscripcion ins in inscripcionesVencidas) {
                    Console.WriteLine($"El curso {ins.NombreCurso} ha expirado con {(DateTime.Now - ins.FechaLimiteEntrega).ToString("dd")} dias de retraso");
                }

            } else {
                Console.WriteLine("No hay inscripciones vencidas");
            }
        }
    }
}
