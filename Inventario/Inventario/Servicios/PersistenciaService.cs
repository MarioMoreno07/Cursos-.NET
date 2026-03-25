using Inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Inventario.Servicios {
    internal class PersistenciaService {
        public void LanzarPersistencia(InventarioService inventarioService) {

            string jsonInscripcion = JsonSerializer.Serialize(inventarioService.productos);
            File.WriteAllText("inventario.json", jsonInscripcion);

        }

        public void LeerPersistencia(InventarioService inventarioService) {

            if (File.Exists("inventario.json")) {

                List<Proucto> products = JsonSerializer.Deserialize<List<Proucto>>(File.ReadAllText("inventario.json")) ?? new List<Proucto>();
                inventarioService.productos = products;
            }
        }
    }
}
