using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD.Modelos {
    internal class Esqueletos : NPC {

        public Esqueletos() : base() {

            Vida = 110;
            Ataque = 12;
            Defense = 6;
            Velocidad = 8;
        
        
        }

        public override int Atacar(int daño) {
            return daño;
        }
    }
}
