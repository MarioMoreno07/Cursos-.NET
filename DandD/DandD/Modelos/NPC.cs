using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD.Modelos {
    internal abstract class NPC {

        protected int Vida { get; set; }
        protected int Ataque { get; set; }
        protected int Defense { get; set; }
        protected int Velocidad { get; set; }


        public abstract int Atacar(int daño);

       

        



    }
}
