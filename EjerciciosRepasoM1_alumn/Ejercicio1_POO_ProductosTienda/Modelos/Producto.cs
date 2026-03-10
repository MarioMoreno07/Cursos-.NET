namespace Ejercicio1_POO_ProductosTienda.Modelos;

public abstract class Producto
{
    private string _nombre = string.Empty;

    public string Nombre
    {
        get => _nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");

            _nombre = value;
        }
    }

    public decimal PrecioBase { get; set; }

    protected Producto(string nombre, decimal precioBase)
    {
        Nombre = nombre;
        PrecioBase = precioBase;
    }

    public abstract decimal CalcularPrecioFinal();
}
