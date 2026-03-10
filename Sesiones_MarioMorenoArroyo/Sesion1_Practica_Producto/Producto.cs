using System;

namespace Sesion1_Practica_Producto {
    class Producto {
        string NombreProducto {  get; set; }
        double PrecioProducto { get; set; }

        public Producto(string nombre , double precioProducto) {
            NombreProducto = nombre;
            PrecioProducto = precioProducto;
        }

        public void MostrarInfo() {
            Console.WriteLine( "El producto con nombre"+ NombreProducto+"cuesta: " + 
                PrecioProducto);
        }
        public double AplicarDescuento(double valor) { 
            
            return PrecioProducto= PrecioProducto * valor; 
        
        }

    }
}
