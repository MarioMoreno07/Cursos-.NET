using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD.Modelos {
    internal class Bosses : NPC {

        private string NombreBoss { get;}
        private bool AtaqueEspecial = false;

        public Bosses(string nombreBoss):base() {
            
            NombreBoss = nombreBoss;
            Vida = 250;
            Ataque = 30;
            Defense = 20;
            Velocidad = 20;
        }

        public override int Atacar(int daño) {
            return 0;
        }

    }
}
