using GestorAcademiaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GestorAcademiaApp.Servicio {
    internal class AlumnoService {
        internal List<Alumno> alumnoList = new List<Alumno>();

        public void RegistrarAlumnos(Alumno alumno) {
            if (!ExisteAlumno(alumno)) {
                alumnoList.Add(alumno);
                Console.WriteLine("Alumno registrado");
            } else {
                Console.WriteLine("El alumno ya existe");
            }
        }
        public bool ValidarEmail(string email) {
            
            bool valid = true;

            if (email == null || !email.Contains("@") || !email.Contains(".")) {
                 valid = false;
            }
            return valid;
        }

        public void MostrarALumnos() {
            foreach (Alumno alumno in alumnoList) {

                Console.WriteLine($"El alumno {alumno.Nombre} con email {alumno.Email} , ha sacado estas notas {alumno.Notas[0]},{alumno.Notas[1]},{alumno.Notas[2]},{alumno.Notas[3]},{alumno.Notas[4]}");
            }
        }

        public bool ExisteAlumno(Alumno alumno) {
            bool r = false;
            bool encontrado = false;

            for (int i = 0; i < alumnoList.Count && !encontrado; i++) { 
                if(alumnoList.ElementAt(i).Email.Equals( alumno.Email)) {
                    encontrado = true;
                    r = true;
                }
            
            }

            return r;
        }
        
    }
}
