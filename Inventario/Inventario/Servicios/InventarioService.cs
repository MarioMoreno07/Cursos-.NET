using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Servicios {
    public class InventarioService {

        public List<Proucto> productos = new List<Proucto>();

        public bool AgregarProducto(Proucto prod) {
            bool r = false;

            if (prod == null) {
                throw new ArgumentNullException("El producto esta vacio");
            } else {

               

                    if (productos.Where(producto => producto.Codigo.Equals(prod.Codigo)).Count() >0) {

                        throw new ArgumentException("Ese producto ya existe");

                    } else if(prod.Precio <= 0) {
                        throw new ArgumentException("El precio del producto debe ser superior a 1 ");
                    }else if(prod.Stock <= 0) {
                        throw new ArgumentException("El stock del producto debe de ser mayor a 1");
                    }else {
                        productos.Add(prod);
                            r = true;
                    }

                
                return r;
            }

        }

        public void MostrarProducto() {

            if (productos.Count <= 0) {
                throw new ArgumentNullException("No hay productos que mostrar");
            } else {
                foreach (Proucto prod in productos) {
                    Console.WriteLine($"El producto {prod.Nombre}, tiene el codigo {prod.Codigo},y la categoria {prod.Categoria}, tiene un valor de {prod.Precio.ToString("C")} y hay un stock de {prod.Stock} unidades");
                }
            }
               
        }

        public Proucto BuscarPorCodigo(string codigo) {

            Proucto p = null;
            if (string.IsNullOrEmpty(codigo)) {

                throw new ArgumentNullException("El codigo del producto esta vacio");
            } else {

                    p = productos.Where(producto => producto.Codigo.Equals(codigo)).FirstOrDefault();
                    if (p == null) {

                        throw new ArgumentNullException("El producto con ese codigo no exite");
                    }
            }


            return p;
        }

        public List<Proucto> BuscarPorCategoria(string categoria) {

            List<Proucto> prodPorCategoria = new List<Proucto>();

            if (string.IsNullOrEmpty(categoria)) {

                throw new ArgumentNullException("La categoria no puede estar vacia");
            } else {

                    prodPorCategoria = productos.Where(producto => producto.Categoria.Equals(categoria)).ToList();
                    if (prodPorCategoria.Count == null) {

                        throw new ArgumentNullException("No existen productos con esa categoria");
                    }
            }

            return prodPorCategoria;

        }


        public bool ReponerStock(string codigo, int cantidad) {

            bool r = false;
            Proucto p = null;
            if (string.IsNullOrEmpty(codigo)) {

                throw new ArgumentNullException("El codigo del producto esta vacio");
            } else {

                
                    p = productos.Where(producto => producto.Codigo.Equals(codigo)).FirstOrDefault();
                    if (p == null) {

                        throw new ArgumentNullException("El producto con ese codigo no exite");
                    }

                
                if (cantidad <= 0) {
                    throw new ArgumentException("La cantidad no puede ser ni 0 ni menor a 0");
                } else {
                    p.Stock = p.Stock+cantidad;
                    r = true;
                }

            }
            return r;

        }

        public bool VenderProdcuto(string codigo, int cantidad) {

            bool r = false;
            Proucto p = null;
            if (string.IsNullOrEmpty(codigo)) {

                throw new ArgumentNullException("El codigo del producto esta vacio");
            } else {

     
                    p = productos.Where(producto => producto.Codigo.Equals(codigo)).FirstOrDefault();
                    if (p == null) {

                        throw new ArgumentNullException("El producto con ese codigo no exite");
                    }
                
                if (cantidad <= 0) {
                    throw new ArgumentException("La cantidad no puede ser ni 0 ni menor a 0");

                } else if(p.Stock < cantidad) {

                    throw new ArgumentException($"No tenemos esa cantidad de producto, solo de disponemos de {p.Stock}");

                } else {
                    p.Stock = p.Stock - cantidad;
                    Console.WriteLine($"El total es de: {(p.Precio * cantidad).ToString("C")}");
                    r = true;
                }

            }
            return r;



        }


        public double CalcularValorTotalInventario() {

            Double total = 0;

            if (productos.Count == 0) {
                throw new NullReferenceException("El inventaio esta vacio");
            } else {
                foreach (Proucto prod in productos) {

                    total = total + (prod.Stock * prod.Precio);
                }


            }
                return total;
        
        }

        public List<Proucto> ObtenerBajoStock(int minimo) {

            List<Proucto> productosBajoMinimo = new List<Proucto>();

            if (minimo < 1) {

                throw new ArgumentException("El minimo debe de ser mayor de 0");
            } else {

                productosBajoMinimo = productos.Where(producto => producto.Stock < minimo).ToList();
            }
            if (productosBajoMinimo.Count == null) {

                throw new ArgumentNullException("No existen productos bajo ese minimo");
            }


            return productosBajoMinimo;
        }
    }
}
