using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD.Modelos {
    internal class Zombies : NPC {

        public Zombies() : base() {

            Vida = 100;
            Ataque = 10;
            Defense = 4;
            Velocidad = 1;
        
        }
        public override int Atacar(int daño) {
            return daño;
        }
    }
}
