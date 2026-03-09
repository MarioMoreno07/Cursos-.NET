using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISP
{
     class Robot : ITrabajador
    {
        public string nombre {  get; set; }

        public Robot(string nombre) {
            nombre = nombre;
        }
        public void Trabajar()
        {
            Console.WriteLine("El robot trabaja");
        }
    }
}
