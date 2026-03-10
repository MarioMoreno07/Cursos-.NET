namespace Ejercicio1_POO_ProductosTienda.Modelos;

public class ProductoDigital : Producto
{
    public ProductoDigital(string nombre, decimal precioBase)
        : base(nombre, precioBase)
    {
    }

    public override decimal CalcularPrecioFinal()
    {
        return PrecioBase;
    }
}
