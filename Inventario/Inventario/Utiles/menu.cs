using Inventario.Modelos;
using Inventario.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Utiles {
    internal class menu {
        InventarioService invertarioService = new InventarioService();
        PersistenciaService persistenciaService = new PersistenciaService();
        public void MostrarMenu() {

            int opcion = -1;
            persistenciaService.LeerPersistencia(invertarioService);
            do {
                Console.Clear();
                Console.WriteLine("\n === GESTOR ACADÉMICO === ");
                Console.WriteLine(" 1.Agregar producto ");
                Console.WriteLine(" 2.Mostrar productos");
                Console.WriteLine(" 3.Buscar por código ");
                Console.WriteLine(" 4.Buscar por categoria");
                Console.WriteLine(" 5.Reponer stock ");
                Console.WriteLine(" 6.Vender producto");
                Console.WriteLine(" 7.Mostrar productos con bajo stock");
                Console.WriteLine(" 8. Mostrar valor total del inventario ");
                Console.WriteLine(" 0.Salir");
                bool esNum = int.TryParse(Console.ReadLine(), out opcion);

                while (!esNum) {
                    Console.WriteLine("Debes e introucir un numero");
                    esNum = int.TryParse(Console.ReadLine(), out opcion);
                }

                switch (opcion) {

                    case 1:
                        try {
                           
                            Console.WriteLine("Como se va a llamar el producto");
                            string nombreProductoAnadir = Console.ReadLine();
                            Console.WriteLine("Dime el codigo del producto");
                            string codigoProdAnadir = Console.ReadLine();
                            Console.WriteLine("Cual es la categoria del producto");
                            string categoriaProdAnadir = Console.ReadLine();
                            Console.WriteLine("Cual es el precio del producto");
                            bool precioProdAnadir = double.TryParse(Console.ReadLine(), out double precioProd);
                            Console.WriteLine("Cual es el stock del producto");
                            bool stockProdcAnadir = int.TryParse(Console.ReadLine(), out int stockProd);

                            Proucto prodAnadir = new Proucto(codigoProdAnadir, nombreProductoAnadir, categoriaProdAnadir, precioProd, stockProd);
                            invertarioService.AgregarProducto(prodAnadir);
                            Console.WriteLine("Producto añadido");

                            
                        } catch (Exception ex) {

                            if (ex is ArgumentNullException || ex is ArgumentException) {
                                Console.WriteLine(ex.Message);
                               
                            }

                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 2:
                        try {
                            invertarioService.MostrarProducto();
                            
                        }catch(NullReferenceException e) {
                            Console.WriteLine(e.Message);
                          
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 3:
                        try {
                            Proucto prd = null;
                            Console.WriteLine("Dime el codigo del producto que deseas buscar");
                            string codBuscar = Console.ReadLine();
                            prd = invertarioService.BuscarPorCodigo(codBuscar);
                            Console.WriteLine($"El producto con ese codigo es: {prd.Nombre}");
                           
                        } catch (ArgumentNullException e) {
                            Console.WriteLine(e.Message);
                            
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 4:
                        try {
                            List<Proucto> list = new List<Proucto>();
                            Console.WriteLine("Dime la categoria del producto que deseas buscar");
                            string catBuscar = Console.ReadLine();
                            list = invertarioService.BuscarPorCategoria(catBuscar);
                            Console.WriteLine("El producto con esa categorias son: ");
                            foreach (Proucto prd in list) {
                                Console.WriteLine($"{prd.Nombre}");
                            }
                           
                        } catch (ArgumentNullException e) {
                            Console.WriteLine(e.Message);
                           
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 5:
                        try {
                            Console.WriteLine("Cual es el codigo del producto que deseas reponer");
                            string codReponer = Console.ReadLine();
                            Console.WriteLine("Dime la cantidad que deseas reponer");
                            bool esParse = int.TryParse(Console.ReadLine(), out int cantReponer);
                            invertarioService.ReponerStock(codReponer, cantReponer);
                           
                        } catch (Exception ex) {

                            if (ex is ArgumentNullException || ex is ArgumentException) {
                                Console.WriteLine(ex.Message);
                                ;
                            }
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 6:
                        try {
                            Console.WriteLine("Cual es el codigo del producto que deseas comprar");
                            string codVender = Console.ReadLine();
                            Console.WriteLine("Dime la cantidad que deseas comprar");
                            bool esParse = int.TryParse(Console.ReadLine(), out int cantVender);
                            invertarioService.VenderProdcuto(codVender, cantVender);
                            
                        } catch (Exception ex) {

                            if (ex is ArgumentNullException || ex is ArgumentException) {
                                Console.WriteLine(ex.Message);
                               
                            }
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 7:
                        try {
                            List<Proucto> listBajoStock = new List<Proucto>();
                            Console.WriteLine("Dime cual es la cantiad de producto minimo");
                            bool parse = int.TryParse(Console.ReadLine(), out int cantMinima);
                            listBajoStock=invertarioService.ObtenerBajoStock(cantMinima);
                            foreach (Proucto prd in listBajoStock) {
                                Console.WriteLine($"{prd.Nombre}");
                            }
                            
                        } catch(ArgumentException ex){    
                            Console.WriteLine(ex.Message);
                            
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 8:
                        try {
                            Console.WriteLine($"EL total del inventaio es de : {invertarioService.CalcularValorTotalInventario().ToString("C")} ");
                            
                        } catch (ArgumentNullException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("Pulse cualquier tecla para salir");
                        Console.ReadLine();
                        break;
                    case 0:
                        persistenciaService.LanzarPersistencia(invertarioService);
                        Console.WriteLine("Gracias por usar nuestro inventario.");
                        break;
                    default:
                        Console.WriteLine("Numero incorrecto");
                        break;
                }
            } while (opcion != 0 || opcion > 9);
        }
    } 
}


            