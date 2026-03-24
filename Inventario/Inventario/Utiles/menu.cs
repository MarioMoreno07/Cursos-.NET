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
        public void MostrarMenu() {

            int opcion = -1;

            do {
                Console.Clear();
                Console.WriteLine("\n === GESTOR ACADÉMICO === ");
                Console.WriteLine(" 1.Agregar producto ");
                Console.WriteLine(" 2.Mostrar productos");
                Console.WriteLine(" 3.Buscar por código ");
                Console.WriteLine(" 4.Reponer stock ");
                Console.WriteLine(" 5.Vender producto");
                Console.WriteLine(" 6.Mostrar productos con bajo stock");
                Console.WriteLine(" 7. Mostrar valor total del inventario ");
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
                            bool r= invertarioService.AgregarProducto(prodAnadir);
                            

                            Console.WriteLine("Pulse cualquier tecla para salir");
                            Console.ReadLine();
                        } catch (Exception ex) {

                            if (ex is ArgumentNullException || ex is ArgumentException) {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Pulse cualquier tecla para salir");
                                Console.ReadLine();
                            }

                        }

                        break;
                    case 2:
                        try {
                            invertarioService.MostrarProducto();
                            Console.WriteLine("Pulse cualquier tecla para salir");
                            Console.ReadLine();
                        }catch(ArgumentNullException e) {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Pulse cualquier tecla para salir");
                            Console.ReadLine();
                        }
                        break;


                }
            } while (opcion != 10 || opcion > 8);
        }
    } 
}


            