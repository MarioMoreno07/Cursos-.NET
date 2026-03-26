using BibliotecaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaApp.Servicios {
    public class PersistenciaService {

        public bool LanzarPersistenciaUsuario(UsuarioService usuarioService) {
            bool r = false;

            if (usuarioService.usuarios.Count > 0) {
                string jsonCurso = JsonSerializer.Serialize(usuarioService.usuarios);
                File.WriteAllText("Usuarios.json", jsonCurso);
                r = true;
            } else {
                throw new NullReferenceException("La lista de usuarios esta vacia");
            }

                return r;
        }
        public bool LanzarPersistenciaLibro(BibliotecaService bibliotecaService) {
            bool r = false ;
            if (bibliotecaService.libros.Count > 0) {
                string jsonCurso = JsonSerializer.Serialize(bibliotecaService.libros);
                File.WriteAllText("Libros.json", jsonCurso);
                r = true;
            } else {
                throw new NullReferenceException("La lista de libros esta vacia");
            }

            return r;
        }
        public bool LanzarPersistenciaPrestamos(PrestamoService prestamoService) {
            bool r = false;

            if(prestamoService.prestamos.Count > 0) {
                string jsonCurso = JsonSerializer.Serialize(prestamoService.prestamos);
                File.WriteAllText("Prestamos.json", jsonCurso);
                r = true;
            } else {
                throw new NullReferenceException("La lista de libros esta vacia");
            }
                return r;
        }






        public bool LeerPersistenciaUsuarios(UsuarioService usuarioService) {
            bool r = false;
            if (File.Exists("Usuarios.json")) {

                List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(File.ReadAllText("Usuarios.json")) ?? new List<Usuario>();
                if(usuarios.Count > 0) {
                    usuarioService.usuarios = usuarios;
                    r = true;
                } else {
                    throw new NullReferenceException("La lista esta vacia");
                }
               
            } else {
                throw new NullReferenceException("El archivo JSON de usuarios no existe");
            }
            return r;
        }

        public bool LeerPersistenciaLibros(BibliotecaService bibliotecaService) {
            bool r = false;
            if (File.Exists("Libros.json")) {

                List<Libro> libros = JsonSerializer.Deserialize<List<Libro>>(File.ReadAllText("Libros.json")) ?? new List<Libro>();
                if (libros.Count > 0) {
                    bibliotecaService.libros = libros;
                    r= true;
                } else {
                    throw new NullReferenceException("La lista esta vacia");
                }
            } else {
                throw new NullReferenceException("El archivo JSON de libros no existe");
            }
            return r;
        }

        public bool LeerPersistenciaPrestamos(PrestamoService prestamoService) {
            bool r = false;
            if (File.Exists("Prestamos.json")) {

                List<Prestamo> prestamos = JsonSerializer.Deserialize<List<Prestamo>>(File.ReadAllText("Prestamos.json")) ?? new List<Prestamo>();
                if(prestamos.Count > 0) {
                    prestamoService.prestamos = prestamos;
                    r = true;
                } else {
                    throw new NullReferenceException("La lista esta vacia");
                }
                
            } else {
                throw new NullReferenceException("El archivo JOSN de prestamos no existe");
            }
            return r;
        }
    }
}
