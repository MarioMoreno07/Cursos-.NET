using BibliotecaEFCore.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEFCore.Data {
    public class BibliotecaDbContext : DbContext {
        public DbSet<Libro> Libros => Set<Libro>();
        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Prestamo> Prestamos => Set<Prestamo>();


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            // Tabla Libros
            modelBuilder.Entity<Libro>(e => {
                e.ToTable(" Libros ");
                e.HasKey(x => x.Id);

                e.Property(x => x.Titulo).HasMaxLength(200).IsRequired();
                e.Property(x => x.Autor).HasMaxLength(150).IsRequired();
                e.Property(x => x.Categoria).HasMaxLength(100).IsRequired();
                e.Property(x => x.Anio).IsRequired();
                e.Property(x => x.Disponible).IsRequired();
            }
                 );
            // Tabla Usuarios
            modelBuilder.Entity<Usuario>(e => {
                e.ToTable(" Usuarios ");
                e.HasKey(x => x.Id);

                e.Property(x => x.Nombre).HasMaxLength(150).IsRequired();
                e.Property(x => x.Dni).HasMaxLength(20).IsRequired();
                e.HasIndex(x => x.Dni).IsUnique();
                e.Property(x => x.FechaAlta).IsRequired();
            }
            );
            // Tabla Prestamos
            modelBuilder.Entity<Prestamo>(e => {
                e.ToTable(" Prestamos ");
                e.HasKey(x => x.Id);

                e.Property(x => x.FechaPrestamo).IsRequired();
                e.Property(x => x.FechaDevolucion).IsRequired();
                e.Property(x => x.FechaDevolucionReal).IsRequired(false);

                e.HasOne(x => x.Libro)
                .WithMany(l => l.Prestamos)
                .HasForeignKey(x => x.LibroId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasOne(x => x.Usuario)
                .WithMany(u => u.Prestamos)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

                // Nota: En la BD hay una UNIQUE(LibroId, FechaDevolucionReal) para
                //limitar préstamos activos.
                // EF no modela esa constraint exactamente aquí; se respeta en BD
                //igualmente.
            });
        }
    }
}
