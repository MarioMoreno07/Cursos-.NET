using BibliotcaSwagger.Dtos.Libros;
using BibliotcaSwagger.Dtos.Prestamos;
using BibliotcaSwagger.Dtos.Usuarios;
using BibliotcaSwagger.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotcaSwagger.Servicios {
    public static class Mapping {
        public static LibroReadDto ToReadLibroDto(this Libro libro) {
            return new LibroReadDto {
                Id = libro.Id,
                Titulo = libro.Titulo,
                Autor = libro.Autor,
                Categoria = libro.Categoria,
                Anio = libro.Anio,
                Disponible = libro.Disponible
            };
        }

        public static UsuarioReadDto ToReadUsuarioDto(this Usuario usuario) {
            return new UsuarioReadDto {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
                Dni = usuario.Dni,
                FechaAlta = usuario.FechaAlta

            };
        }

        public static PrestamoReadDto ToReadPrestamoDto(this Prestamo prestamo) {
            return new PrestamoReadDto {
                Id = prestamo.Id,
                LibroId = prestamo.LibroId,
                UsuaioId = prestamo.UsuarioId,
                NombreUsuario = prestamo.Usuario.Nombre,
                TituloLibro = prestamo.Libro.Titulo,
                FechaPrestamo = prestamo.FechaPrestamo,
                FechaDevolucion = prestamo.FechaDevolucion,
                FechaDevolucionReal = prestamo.FechaDevolucionReal,
                Activo = prestamo.EstaActivo(),
                Vencido = prestamo.EstaVencido()
            };
        }
    }
}
