using Ejercicio1_POO_ProductosTienda.Modelos;

namespace Ejercicio1_POO_ProductosTienda;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Producto> productos = new()
        {
            new ProductoFisico("Teclado", 30m, 5m),
            new ProductoDigital("Curso C#", 25m),
            new ProductoReacondicionado("Camara",30m,7m)
        };

        foreach (var producto in productos)
        {
            Console.WriteLine($"Producto: {producto.Nombre}");
            Console.WriteLine($"Precio final: {producto.CalcularPrecioFinal():0.00} €");
            Console.WriteLine(new string('-', 30));
        }
    }
}
