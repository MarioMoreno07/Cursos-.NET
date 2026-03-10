namespace Ejercicio1_POO_ProductosTienda.Modelos;

public class ProductoFisico : Producto
{
    public decimal GastosEnvio { get; set; }

    public ProductoFisico(string nombre, decimal precioBase, decimal gastosEnvio)
        : base(nombre, precioBase)
    {
        GastosEnvio = gastosEnvio;
    }

    public override decimal CalcularPrecioFinal()
    {
        return PrecioBase + GastosEnvio;
    }
}
