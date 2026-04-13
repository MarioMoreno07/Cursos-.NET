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
                Console.WriteLine("6. Listar Usuarios");
                Console.WriteLine("7. Insertar Usuario");
                Console.WriteLine("8. Borrar Usuario");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                while (!int.TryParse(Console.ReadLine(), out opcion)) {
                    Console.Write("Opción válida: ");
                }

                switch (opcion) {
                    case 1: ListarLibros(); Console.WriteLine("Pulse para salir");Console.ReadLine() ;break;
                    case 2: InsertarLibro(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 3: Estadisticas(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 4: BorrarLibro(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 5: ActualizarLibro(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 6: ListarUsuarios(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 7: InsertarUsuario(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
                    case 8: BorrarUsuario(); Console.WriteLine("Pulse para salir"); Console.ReadLine(); break;
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
        private void Estadisticas() {
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
    }
}