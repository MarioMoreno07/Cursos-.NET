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

        
        Console.WriteLine("----------------WHERE---------------------");
        var disponibles = libros.Where(l => l.Disponible).ToList();
        Console.WriteLine("Los libros disponibles son: ");
        foreach (var d in disponibles) { 
            Console.WriteLine(d.Titulo);
        }

        Console.WriteLine("----------------ORDER BY ---------------------");
        var ordenadosAño = libros.OrderBy(l => l.Anio).ToList();
        var ordenadosTitulo = libros.OrderBy(l => l.Titulo);
        Console.WriteLine("Libros ordenados por año: ");
        foreach(var d in ordenadosAño) {
            Console.WriteLine(d.Titulo+" ");
        }

        Console.WriteLine("Libros ordenados por titulo: ");
        foreach (var d in ordenadosTitulo) {
            Console.WriteLine(d.Titulo + " ");
        }

        Console.WriteLine("----------------SELECT---------------------");

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
        Console.WriteLine("----------------COUNT ---------------------");
        var countPorCategoria = libros.GroupBy(l => l.Categoria).Select(g => new {});
        Console.WriteLine("Total de categorias: " + countPorCategoria.Count());

        var countDisponibles = libros.GroupBy(l => l.Disponible).Select(g => new { });
        Console.WriteLine("Total disponibles: " + countDisponibles.Count());

        var totalLibros = libros.Count();
        Console.WriteLine("Total libros: "+totalLibros);

        Console.WriteLine("----------------FIRSTORDEFAULT/FIRST ---------------------");

        var libroPorId = libros.Select(l => l.Id).FirstOrDefault();
        var libroPorTitulo = libros.Select(l=>l.Titulo).FirstOrDefault();
        Console.WriteLine("El primer libro por id es: "+libroPorId);
        Console.WriteLine("El primer libro por tituloes: "+libroPorTitulo);

        Console.WriteLine("----------------ANY---------------------");

        bool disponibilidad = libros.Any(l=>l.Disponible);
        bool libroConcreto = libros.Any(l => l.Titulo == "Principito");
        Console.WriteLine("Algun libro disponible: "+disponibilidad);
        Console.WriteLine("Esta el libro del Principito: "+libroConcreto);


        Console.WriteLine("----------------SKIP/TAKE---------------------");

        var paginas = libros.OrderBy(l => l.Id).Skip(0).Take(2);
        foreach (var pagin in paginas) {
            Console.WriteLine(pagin.Titulo);
        }
        Console.WriteLine("----------------UPDATE---------------------");

        var libro = libros.FirstOrDefault(l => l.Id == 1);
        if (libro != null) {
            libro.Disponible = !libro.Disponible;
        }
        Console.WriteLine("El libro con id 1 esta disponible: "+libro.Disponible);
        
        var datos = libros.FirstOrDefault(l => l.Id == 1);
        if (datos != null) {
            datos.Autor = "Desconocido";
            datos.Anio = 5670;
        }
        Console.WriteLine("Autor: "+datos.Autor + " Anio: " +datos.Anio);

        Console.WriteLine("----------------DELETE---------------------");

        libros.RemoveAll(l => l.Id != 1);
        foreach (Libro l in libros) {
            Console.WriteLine($"El libro con id {l.Id} , fue escrito por {l.Autor}");
         }
    }
}