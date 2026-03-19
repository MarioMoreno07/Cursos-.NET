using GestorAcademiaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Servicio {
    internal class CursoService1 {

        public List<Curso> cursos { get; set; } = new List<Curso>();
        public void MostrarCursos() {

            foreach (Curso curso in cursos) {
                Console.WriteLine($"El curso con el nombre {curso.Nombre}, tiene una duracion de {curso.NumHoras}");
            }

        }

        public void AnadirCurso(Curso curso) {

           
               
                if(cursos.Contains(curso)) {
                    Console.WriteLine("Curso ya existente");
                } else {
                    cursos.Add(curso);
                    Console.WriteLine("Curso creado");
                }
            
               
               
            } 

        }
    }
