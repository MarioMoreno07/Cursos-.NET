using GestorAcademiaApp.Modelos;
using GestorAcademiaApp.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Utilidades {
    internal class Menu {
        AlumnoService alumnoService = new AlumnoService();
        CursoService1 cursoService = new CursoService1();
        InscripcionService inscripcionService = new InscripcionService();
        ReporteService reporteService = new ReporteService();
        PersistenciaService persistenciaService = new PersistenciaService();

        public void MostrarMenu() {

            int opcion = -1;
            persistenciaService.LeerPersistencia(cursoService,alumnoService,inscripcionService);
            do {
                Console.Clear();
                Console.WriteLine("\n === GESTOR ACADÉMICO === ");
                Console.WriteLine(" 1.Registrar alumno ");
                Console.WriteLine(" 2.Mostrar alumnos");
                Console.WriteLine(" 3.Registrar cursos ");
                Console.WriteLine(" 4.Mostrar cursos ");
                Console.WriteLine(" 5.Inscribir alumno en curso");
                Console.WriteLine(" 6.Mostrar inscripciones");
                Console.WriteLine(" 7. Analizar notas ");
                Console.WriteLine(" 8. Estadísticas generales");
                Console.WriteLine(" 9. Inscripciones vencidas");
                Console.WriteLine(" 10.Salir");
                bool esNum = int.TryParse(Console.ReadLine(), out opcion);

                while (!esNum) {
                    Console.WriteLine("Debes e introucir un numero");
                    esNum = int.TryParse(Console.ReadLine(), out opcion);
                }

                switch (opcion) {

                    case 1:
                        int[] notas = new int[5];
                        Console.WriteLine("Cual es tu email");
                        string email = Console.ReadLine();
                        while (!alumnoService.ValidarEmail(email.ToLower())) {
                            Console.WriteLine("El email debe contener @  y .");
                            email = Console.ReadLine();
                        }
                        if (alumnoService.alumnoList.Where(alumno => alumno.Email.Equals(email.ToLower())).FirstOrDefault() is not null) {
                            for (int i = 0; i < notas.Length; i++) {
                                Console.WriteLine($"Dime tu nota del examen {i}");
                                bool parse = int.TryParse(Console.ReadLine(), out int nota);
                                notas[i] = nota;
                                while (nota < 0 || nota > 10) {
                                    Console.WriteLine("La nota no puede ser menor a 0 y mayor a 10");
                                    parse = int.TryParse(Console.ReadLine(), out nota);
                                    notas[i] = nota;
                                }
                            }
                           Alumno alm= alumnoService.alumnoList.Where(alumno => alumno.Email.Equals(email.ToLower())).First();
                            alm.Notas = notas;
                        
                        } else {
                            Console.WriteLine("No estas inscrito a ningun curso. Debes apuntarte en uno para que podamos actualizar tus notas, aqui estan los cursos " +
                                "que tenemos actualmente");
                            cursoService.MostrarCursos();

                        }
                            Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 2:
                        alumnoService.MostrarALumnos();
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Nombre del curso");
                        string nombreCuso = Console.ReadLine() ;
                        Console.WriteLine("Cuantas horaas dura el curso");
                        bool parseHoras = int.TryParse(Console.ReadLine(),out int hora);
                        Curso curso = new Curso(nombreCuso.ToLower(),hora);
                        cursoService.AnadirCurso(curso);
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 4:
                        cursoService.MostrarCursos();
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 5:
                        
                        Console.WriteLine("Dime tu nombre");
                        string nombreAL = Console.ReadLine() ;
                        Console.WriteLine("Dime tu email");
                        string emailAL = Console.ReadLine() ;
                        while (!alumnoService.ValidarEmail(emailAL.ToLower())) {
                            Console.WriteLine("El email debe contener @  y .");
                            emailAL = Console.ReadLine();
                        }
                        Console.WriteLine("Cual es el nombre del curso");
                        string nombreCu = Console.ReadLine() ;

                        int[] notasVacias = new int[5];
                        Alumno alumnoAL = new Alumno(nombreAL.Trim(), emailAL.ToLower(), notasVacias);
                        alumnoService.RegistrarAlumnos(alumnoAL);

                        Inscripcion ins = new Inscripcion(emailAL.ToLower(), nombreCu.ToLower());
                        inscripcionService.InscribirAlumno(ins,alumnoService,cursoService);
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 6:
                        inscripcionService.MostrarInscripciones();
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Dime tu email");
                        string usuarioAComprobar = Console.ReadLine().ToLower();
                        bool encontrado = false;
                        Alumno al = null;

                        for(int i = 0; i<alumnoService.alumnoList.Count && !encontrado; i++) {
                            if(usuarioAComprobar == alumnoService.alumnoList.ElementAt(i).Email) {
                                al = alumnoService.alumnoList[i];
                                reporteService.AnalizarNotas(al);
                                encontrado = true;
                            } else {
                                Console.WriteLine("No existe ese alumno");
                            }

                        } 
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 8:
                        reporteService.EstadisticasGenerales(alumnoService);

                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 9:
                        reporteService.InscripcionesVencidas(inscripcionService);
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 10:
                        persistenciaService.LanzarPersistencia(cursoService,alumnoService, inscripcionService);
                        Console.WriteLine("Gracias por usar nuestra academia");
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    default:
                        
                        Console.WriteLine("Numero no valido");
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                
                }
            } while (opcion != 10 || opcion > 11);
        }


            
    }
}
