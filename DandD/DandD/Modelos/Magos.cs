using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD.Modelos {
    internal class Magos : NPC {


        public Magos():base() {

            Vida = 120;
            Ataque = 15;
            Defense = 12;
            Velocidad = 10;
        
        }

        public override int Atacar(int daño) {
            return daño;
        }
    }
}
