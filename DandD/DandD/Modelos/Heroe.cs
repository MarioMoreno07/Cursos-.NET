using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD.Modelos {
    internal class Heroe : NPC {

        private string Nombre;
        private Clase ClaseHeroe;


        public Heroe(string nombre, Clase claseHeroe)  {
            Nombre = nombre;
            ClaseHeroe = claseHeroe;
            Vida = 100;
            Ataque = 10;
            Velocidad = 10;
            Defense = 10;
        
        }


        public override int Atacar(int daño) {
            return 0;
        }

        // Exclusivo del Heroe
        public void Curarse() {

            Vida= Vida+30;
            
        }
    }
}
