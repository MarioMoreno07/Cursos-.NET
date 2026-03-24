
using Inventario.Utiles;
using System.Globalization;

namespace InventarioApp {


    internal class Program {
        private static void Main(string[] args) {
           menu mn = new menu();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");
            mn.MostrarMenu();
        }
    }
}