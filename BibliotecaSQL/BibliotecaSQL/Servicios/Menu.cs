using BibliotecaSQL.Modelo;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Linq;

namespace BibliotecaSQL.Servicios {
    internal class Menu {
        private readonly string connectionString =
    "Server=localhost\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True; TrustServerCertificate=True;";

        public void Iniciar() {
            int opcion;
            do {
                Console.Clear();
                Console.WriteLine("\n=== BIBLIOTECA SQL SERVER ===");
                Console.WriteLine("1. Listar Libros");
                Console.WriteLine("2. Insertar Libro");
                Console.WriteLine("3. Mostrar Estadísticas (LINQ)");
                Console.WriteLine("4. Borrar Libro");
                Console.WriteLine("5. Actualizar Libro");
                Console.WriteLine("------------------------------");
                Console.WriteLine("6. Listar Usuarios");
                Console.WriteLine("7. Insertar Usuario");
                Console.WriteLine("8. Borrar Usuario");
                Console.WriteLine("9. Estadisticas Usuarios");
                Console.WriteLine("10. Actualizar Usuario");
                Console.WriteLine("------------------------------");
                Console.WriteLine("11. Listar Prestamo");
                Console.WriteLine("12. Insertar Prestamo");
                Console.WriteLine("13. Borrar Prestamo");
                Console.WriteLine("14. Estadisticas Prestamos");
                Console.WriteLine("15. Actualizar Prestamo");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                while (!int.TryParse(Console.ReadLine(), out opcion)) {
                    Console.Write("Opción válida: ");
                }

                switch (opcion) {
                    case 1: ListarLibros(); Console.WriteLine("Pulse para salir");Console.ReadLine() ;break;
                    case 2: InsertarLibro(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 3: EstadisticasLibros(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 4: BorrarLibro(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 5: ActualizarLibro(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;

                    case 6: ListarUsuarios(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 7: InsertarUsuario(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 8: BorrarUsuario(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 9: EstadisticasUsuarios(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 10: ActualizarUsuario(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;

                    case 11: ListarPrestamos(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 12: InsertarPrestamo(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 13: BorrarPrestamo(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 14: EstadisticasPrestamos(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 15: ActualizarPrestamo(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;


                }

            } while (opcion != 0);
        }

        private void ListarLibros() {
            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "SELECT * FROM Libros";
            SqlCommand cmd = new(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                Console.WriteLine($"{reader["Id"]} - {reader["Titulo"]} - Disponible: {reader["Disponible"]}");
            }
        }

        private void ListarUsuarios() {
            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "SELECT * FROM Usuarios";
            SqlCommand cmd = new(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                Console.WriteLine($"{reader["Id"]} - {reader["Nombre"]}");
            }
        }
        private void ListarPrestamos() {
            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "SELECT * FROM Prestamos p JOIN Libros l ON p.LibroId = l.Id JOIN Usuarios u ON p.UsuarioId = u.Id;";
            SqlCommand cmd = new(query, conn);
            
            SqlDataReader reader = cmd.ExecuteReader();
           

            while (reader.Read()) {
            

                Console.WriteLine($"Libro: {reader["Id"]} - Nombre: {reader["Nombre"]}- Libro: { reader["Titulo"]}");
            }
        }

        private void InsertarLibro() {
            Console.Write("Título: ");
            string titulo = Console.ReadLine() ?? "";

            Console.Write("Autor: ");
            string autor = Console.ReadLine() ?? "";

            Console.Write("Categoría: ");
            string categoria = Console.ReadLine() ?? "";

            Console.Write("Año: ");
            int anio = int.Parse(Console.ReadLine() ?? "0");

            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "INSERT INTO Libros (Titulo, Autor, Categoria, Anio, Disponible) VALUES (@t,@a,@c,@an,1)";
            SqlCommand cmd = new(query, conn);

            cmd.Parameters.AddWithValue("@t", titulo);
            cmd.Parameters.AddWithValue("@a", autor);
            cmd.Parameters.AddWithValue("@c", categoria);
            cmd.Parameters.AddWithValue("@an", anio);

            cmd.ExecuteNonQuery();

            Console.WriteLine("Libro insertado.");
        }
        private void InsertarUsuario() {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Dni: ");
            string dni = Console.ReadLine() ?? "";

            DateTime fechaAlta = DateTime.Now;


            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "INSERT INTO Usuarios (Nombre, Dni, FechaAlta) VALUES (@n,@d,@f)";
            SqlCommand cmd = new(query, conn);

            cmd.Parameters.AddWithValue("@n", nombre);
            cmd.Parameters.AddWithValue("@d", dni);
            cmd.Parameters.AddWithValue("@f",fechaAlta);
          

            cmd.ExecuteNonQuery();

            Console.WriteLine("Usuario insertado.");
        }

        private void InsertarPrestamo() {
            Console.Write("Id usuario: ");
            string idUsuario = Console.ReadLine() ?? "";

            Console.Write("Id libro: ");
            string idLibro = Console.ReadLine() ?? "";

            DateTime fechaPrestamo = DateTime.Now;
            DateTime FechaDevolucion = DateTime.Now.AddDays(20);


            using SqlConnection conn = new(connectionString);
            conn.Open();

            string queryUser = $"SELECT * FROM Usuarios WHERE Id = {idUsuario}";
            string queryLibro = $"SELECT * FROM Libros WHERE Id = {idLibro}";
            SqlCommand cmd2 = new(queryUser, conn);
            SqlDataReader readerUser = cmd2.ExecuteReader();
            conn.Close();
            conn.Open();
            SqlCommand cmd3 = new(queryLibro, conn);
            SqlDataReader readerLibro = cmd3.ExecuteReader();
            readerLibro.Read();
            bool disponibilidad = (bool)readerLibro["Disponible"];
            conn.Close();
            conn.Open();

            if (readerLibro != null) {
                if (readerUser != null) {
                    if (disponibilidad == true) {
                        
                        string query = "INSERT INTO Prestamos (LibroId, UsuarioId, FechaPrestamo,FechaDevolucion) VALUES (@li,@ui,@fp,@fd)";
                        SqlCommand cmd = new(query, conn);

                        cmd.Parameters.AddWithValue("@li", idLibro);
                        cmd.Parameters.AddWithValue("@ui", idUsuario);
                        cmd.Parameters.AddWithValue("@fp", fechaPrestamo);
                        cmd.Parameters.AddWithValue("@fd", FechaDevolucion);
                        string query2 = $"UPDATE Libros SET Disponible = 0 WHERE id = {idLibro}";
                        SqlCommand cmdUP = new(query2, conn);

                       
                        cmd.ExecuteNonQuery();
                        cmdUP.ExecuteNonQuery();

                        Console.WriteLine("Prestamo insertado.");
                    } else {
                        Console.WriteLine("Libro ya prestado");
                    }
                    
                } else {
                    Console.WriteLine("El id del usuario es incorrecto");
                }
            } else {
                Console.WriteLine("El id del libro es incorrecto");
            }
           
        }
        private void EstadisticasLibros() {
            List<Libro> libros = new();

            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "SELECT * FROM Libros";
            SqlCommand cmd = new(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {

                Libro lib = new Libro((int)reader["Id"], reader["Titulo"].ToString()!, reader["Autor"].ToString()!, reader["Categoria"].ToString()!, 
                    (int)reader["Anio"], (bool)reader["Disponible"]);

                libros.Add(lib);
            }

            var total = libros.Count;
            var disponibles = libros.Count(l => l.Disponible);

            Console.WriteLine($"Total libros: {total}");
            Console.WriteLine($"Disponibles: {disponibles}");
        }

        private void EstadisticasUsuarios() {
            List<Usuario> usuarios = new();

            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "SELECT * FROM Usuarios";
            SqlCommand cmd = new(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {

                usuarios.Add(new Usuario {

                    Id = (int)reader["Id"],
                    Nombre = reader["Nombre"].ToString()!,
                    Dni = reader["Dni"].ToString()!,
                    FechaAlta = (DateTime)reader["FechaAlta"]
                });
            }

            var total = usuarios.Count;
           
            Console.WriteLine($"Total usuarios: {total}");
        }

        private void EstadisticasPrestamos() {
            List<Prestamos> prestamos = new();

            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "SELECT * FROM Prestamos";
            SqlCommand cmd = new(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {

                prestamos.Add(new Prestamos {

                    Id = (int)reader["Id"],
                    IdUsuario = (int)reader["UsuarioId"],
                    IdLibro = (int)reader["LibroId"],
                    FechaPrestamo = (DateTime)reader["FechaPrestamo"],
                    FechaDevolucion = (DateTime)reader["FechaDevolucion"],
                    FechaDevolucionReal = reader["FechaDevolucionReal"].ToString()! ?? null
                });
            }

            var total = prestamos.Count;

            Console.WriteLine($"Total Prestamos: {total}");
        }

        private void BorrarLibro() {
            Console.Write("Id: ");
            int idteclado = int.Parse(Console.ReadLine() ?? "0");

            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "DELETE FROM Libros WHERE id = @id";
            SqlCommand cmd = new(query, conn);

            SqlParameter parametroId = new SqlParameter("@id", idteclado);
            cmd.Parameters.Add(parametroId);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Remove(parametroId);

            Console.WriteLine("Libro eliminado.");
        }

        private void BorrarUsuario() {
            Console.Write("Id: ");
            int idteclado = int.Parse(Console.ReadLine() ?? "0");

            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "DELETE FROM Usuarios WHERE id = @id";
            SqlCommand cmd = new(query, conn);

            SqlParameter parametroId = new SqlParameter("@id", idteclado);
            cmd.Parameters.Add(parametroId);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Remove(parametroId);

            Console.WriteLine("Usuario eliminado.");
        }

        private void BorrarPrestamo() {
            Console.Write("Id: ");
            int idteclado = int.Parse(Console.ReadLine() ?? "0");

            using SqlConnection conn = new(connectionString);
            conn.Open();

            string queryDatos = "SELECT * FROM PRESTAMOS WHERE Id = @id";
            SqlCommand cmd2 = new(queryDatos, conn);
            
            SqlParameter parametroId2 = new SqlParameter("@id", idteclado);
            cmd2.Parameters.Add(parametroId2);
      
            SqlDataReader reader = cmd2.ExecuteReader();
        
            reader.Read();
            string query2 = $"UPDATE Libros SET Disponible = 1 WHERE Id = {(int)reader["LibroId"]}";
            SqlCommand cmdUP = new(query2, conn);
            string query = "DELETE FROM Prestamos WHERE Id = @id";
            SqlCommand cmd = new(query, conn);

            SqlParameter parametroId = new SqlParameter("@id", idteclado);
            cmd.Parameters.Add(parametroId);

            conn.Close();
            conn.Open();
            cmd.ExecuteNonQuery();
            cmdUP.ExecuteNonQuery();
            cmd.Parameters.Remove(parametroId);
            cmd2.Parameters.Remove(parametroId2);

            Console.WriteLine("Prestamo eliminado.");
        }

        private void ActualizarLibro() {
            Console.Write("Introduce el ID del libro a actualizar: ");
            int idteclado = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Introduce el NUEVO título: ");
            string nuevotitulo = Console.ReadLine() ?? "";

            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "UPDATE Libros SET Titulo = @titulo WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlParameter pId = new SqlParameter("@id", idteclado);
            SqlParameter pTitulo = new SqlParameter("@titulo", nuevotitulo);

            cmd.Parameters.Add(pId);
            cmd.Parameters.Add(pTitulo);

            int filas = cmd.ExecuteNonQuery();

            cmd.Parameters.Remove(pId);
            cmd.Parameters.Remove(pTitulo);

            Console.WriteLine($"Se actualizaron {filas} registro(s) y se removieron los parámetros.");
        }

        private void ActualizarUsuario() {
            Console.Write("Introduce el ID del usuario a actualizar: ");
            int idteclado = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Introduce el NUEVO nombre: ");
            string nuevoNombre = Console.ReadLine() ?? "";

            using SqlConnection conn = new(connectionString);
            conn.Open();

            string query = "UPDATE Usuarios SET Nombre = @nombre WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlParameter pId = new SqlParameter("@id", idteclado);
            SqlParameter pNombre = new SqlParameter("@nombre", nuevoNombre);

            cmd.Parameters.Add(pId);
            cmd.Parameters.Add(pNombre);

            int filas = cmd.ExecuteNonQuery();

            cmd.Parameters.Remove(pId);
            cmd.Parameters.Remove(pNombre);

            Console.WriteLine($"Se actualizaron {filas} registro(s) y se removieron los parámetros.");
        }

        private void ActualizarPrestamo() {
            Console.Write("Introduce el ID del prestamo a actualizar: ");
            int idteclado = int.Parse(Console.ReadLine() ?? "0");

            DateTime FechaDevolucionReal = DateTime.Now;
            using SqlConnection conn = new(connectionString);
            conn.Open();

            string queryDatos = "SELECT * FROM PRESTAMOS WHERE Id = @id";
            SqlCommand cmd2 = new(queryDatos, conn);

            SqlParameter parametroId2 = new SqlParameter("@id", idteclado);
            cmd2.Parameters.Add(parametroId2);

            SqlDataReader reader = cmd2.ExecuteReader();

            reader.Read();
            string query2 = $"UPDATE Libros SET Disponible = 1 WHERE Id = {(int)reader["LibroId"]}";
            SqlCommand cmdUP = new(query2, conn);

            string query = "UPDATE Prestamos SET FechaDevolucionReal = @fechaDev WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlParameter pId = new SqlParameter("@id", idteclado);
            SqlParameter pfecha = new SqlParameter("@fechaDev", FechaDevolucionReal);

            cmd.Parameters.Add(pId);
            cmd.Parameters.Add(pfecha);
            conn.Close();
            conn.Open();
            int filas = cmd.ExecuteNonQuery();
            cmdUP.ExecuteNonQuery();

            cmd.Parameters.Remove(pId);
            cmd.Parameters.Remove(pfecha);

            Console.WriteLine($"Se actualizaron {filas} registro(s) y se removieron los parámetros.");
        }
    }
}