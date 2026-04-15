using BibliotcaLinq.Modelos;

internal class Program {
    private static void Main(string[] args) {
        List<Libro> libros = new List<Libro> {
            new Libro { Id = 1, Titulo = "El trabajo del artesano", Autor = "Miguel García",
                Categoria = "Novela", Anio = 2000, Disponible = true },
            new Libro { Id = 2, Titulo = "Don Quijote", Autor = "Cervantes", Categoria =
                "Clásicos", Anio = 1605, Disponible = false },
            new Libro { Id = 3, Titulo = "C#", Autor = "Roberto Fernández", Categoria =
                "Programación", Anio = 2023, Disponible = true }
        };

        /*WHERE*/
        var disponibles = libros.Where(l => l.Disponible).ToList();
        Console.WriteLine("Los libros disponibles son: ");
        foreach (var d in disponibles) { 
            Console.WriteLine(d.Titulo);
        }

        /*Order BY*/
        var ordenadosAño = libros.OrderBy(l => l.Anio).ToList();
        var ordenadosTitulo = libros.OrderBy(l => l.Titulo);
        Console.WriteLine("Libros ordenados por año: ");
        foreach(var d in ordenadosAño) {
            Console.Write(d.Titulo+" ");
        }

        Console.WriteLine("Libros ordenados por titulo: ");
        foreach (var d in ordenadosTitulo) {
            Console.Write(d.Titulo + " ");
        }

        /*SELECT*/

        var titulos = libros.Select(l => l.Titulo);
        var autores = libros.Select(l =>l.Autor);
        
        Console.WriteLine("Solo autores: ");
        foreach (var d in autores) {
            Console.WriteLine(d+" ");
        }
        Console.WriteLine("Solo titulos: ");
        foreach (var d in titulos) {
            Console.WriteLine(d + " ");
        }

       Console.WriteLine("----------------Group by ---------------------");

        var porCategoria = libros.GroupBy(l => l.Categoria).Select(g => new {
                 Categoria = g.Key,
                 Total = g.Count()
             }).ToList();
        foreach (var d in porCategoria) {
            Console.WriteLine(d);
        }
        
        var porAutor = libros.GroupBy(l => l.Autor).Select(g => new {

            Autor = g.Key,
            Total = g.Count()
        }).ToList();
        foreach (var d in porAutor) {
            Console.WriteLine(d);
        }
        /*Count*/
        var countPorCategoria = libros.GroupBy(l => l.Categoria).Select(g => new {});
        Console.WriteLine("Total de categorias: " + countPorCategoria.Count());

        var countDisponibles = libros.GroupBy(l => l.Disponible).Select(g => new { });
        Console.WriteLine("Total disponibles: " + countDisponibles.Count());

        var totalLibros = libros.Count();
        Console.WriteLine("Total libros: "+totalLibros);

        /*Búsqueda (FIRST / FIRSTORDEFAULT)*/

        var libroPorId = libros.Select(l => l.Id).FirstOrDefault();
        var libroPorTitulo = libros.Select(l=>l.Titulo).FirstOrDefault();
        Console.WriteLine("El primer libro por id es: "+libroPorId);
        Console.WriteLine("El primer libro por tituloes: "+libroPorTitulo);

        /*ANY*/

        bool disponibilidad = libros.Any(l=>l.Disponible);
        bool libroConcreto = libros.Any(l => l.Titulo == "Principito");
        Console.WriteLine(disponibilidad);
        Console.WriteLine(libroConcreto);
    }
}