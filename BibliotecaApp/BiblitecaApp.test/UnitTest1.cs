using BibliotecaApp.Modelos;
using BibliotecaApp.Servicios;

namespace BiblitecaApp.test {
    public class Tests {

        private PersistenciaService persistenciaService;
        private BibliotecaService bibliotecaService;
        private PrestamoService prestamoService;
        private UsuarioService usuarioService;

        [SetUp]

        public void Setup() {
            persistenciaService = new PersistenciaService();
            bibliotecaService = new BibliotecaService();
            prestamoService = new PrestamoService();
            usuarioService = new UsuarioService();
        }
        // Tests libros
        [Test]
        public void AgregarLibro() {

            bool resultado = true;
            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);


            Assert.That(bibliotecaService.AgregarLibros(libro), Is.EqualTo(resultado));
        }

        [Test]
        public void BuscarPorTitulo() {
            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);
            bibliotecaService.libros.Add(libro);
            Assert.That(bibliotecaService.buscarLibroPorTitulo("Principito"), Is.EqualTo(libro));
        }

        [Test]
        public void GuardarJSONLibro() {
            bool resultado = true;
            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);
            bibliotecaService.libros.Add(libro);
            Assert.That(persistenciaService.LanzarPersistenciaLibro(bibliotecaService), Is.EqualTo(resultado));

        }
        [Test]
        public void CargarJSONLibro() {
            bool resultado = true;
            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);
            bibliotecaService.libros.Add(libro);
            persistenciaService.LanzarPersistenciaLibro(bibliotecaService);
            Assert.That(persistenciaService.LeerPersistenciaLibros(bibliotecaService), Is.EqualTo(resultado));
        }


        // Tests usuarios

        [Test]
        public void AgregarUsuario() {
            bool resultado = true;
            Usuario user = new Usuario("Paco", "123");
            Assert.That(usuarioService.AgregarUsuario(user), Is.EqualTo(resultado));


        }

        [Test]
        public void BuscarPorDni() {

            Usuario user = new Usuario("Paco", "123");
            usuarioService.usuarios.Add(user);
            Assert.That(usuarioService.BuscarUsuarioDni("123"), Is.EqualTo(user));


        }
        [Test]
        public void GuardarJSONUser() {
            bool resultado = true;
            Usuario user = new Usuario("Paco", "123");
            usuarioService.usuarios.Add(user);
            Assert.That(persistenciaService.LanzarPersistenciaUsuario(usuarioService), Is.EqualTo(resultado));

        }

        [Test]
        public void CargarJSONUser() {
            bool resultado = true;
            Usuario user = new Usuario("Paco", "123");
            usuarioService.usuarios.Add(user);
            persistenciaService.LanzarPersistenciaUsuario(usuarioService);
            Assert.That(persistenciaService.LeerPersistenciaUsuarios(usuarioService), Is.EqualTo(resultado));
        }


        //Test prestamos

        [Test]
        public void RealizarPrestamo() {
            bool resultado = true;
            Usuario user = new Usuario("Paco", "123");
            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);

            Assert.That(prestamoService.RealizarPrestamo(user, libro), Is.EqualTo(resultado));
        }

        [Test]
        public void CambiaEstado() {
            bool resultado = true;

            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);

            Assert.That(prestamoService.MarcarComoNoDisponible(libro), Is.EqualTo(resultado));
        }

        [Test]
        public void yaPrestado() {

            Usuario user = new Usuario("Paco", "123");
            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);
            prestamoService.MarcarComoNoDisponible(libro);

            Assert.Throws<InvalidOperationException>(() => prestamoService.RealizarPrestamo(user, libro));
        }

        [Test]
        public void DevolverLibro() {
            bool resultado = true;
            Usuario user = new Usuario("Paco", "123");
            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);
            prestamoService.RealizarPrestamo(user, libro);


            Assert.That(prestamoService.devolverPrestamo(libro), Is.EqualTo(resultado));
        }
        [Test]
        public void obtenerPrestamosVencidos() {
            List<Prestamo> prest = new List<Prestamo>();
            Usuario user = new Usuario("Paco", "123");
            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);
            prestamoService.RealizarPrestamo(user, libro);
            Prestamo p = prestamoService.prestamos.First();
            p.fechaFinPrestamo = DateTime.Now.AddDays(-1);
            prest = prestamoService.prestamos;

            Assert.That(prestamoService.prestamosVencidos(), Is.EqualTo(prest));
        }

        [Test]
        public void GuardarJSONprestamos() {
            bool resultado = true;

            Usuario user = new Usuario("Paco", "123");
            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);
            prestamoService.RealizarPrestamo(user, libro);

            Assert.That(persistenciaService.LanzarPersistenciaPrestamos(prestamoService), Is.EqualTo(resultado));

        }

        [Test]
        public void CargarJSONPrestamos() {
            bool resultado = true;

            Usuario user = new Usuario("Paco", "123");
            Autor autor = new Autor("Paco");
            Categoria categoria = new Categoria("Fantasia");
            Libro libro = new Libro(autor, "Principito", categoria);
            prestamoService.RealizarPrestamo(user, libro);

            persistenciaService.LanzarPersistenciaPrestamos(prestamoService);
            Assert.That(persistenciaService.LeerPersistenciaPrestamos(prestamoService), Is.EqualTo(resultado));
        }
        [TearDown]

        public void Dispose() {

            File.Delete("Prestamos.JSON");
            File.Delete("Usuarios.JSON");
            File.Delete("Libros.JSON");

        }
    } 
}