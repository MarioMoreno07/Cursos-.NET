using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD.Modelos {
    internal class Clase {

        internal string  NombreClase {  get; set; } 
        internal int VidaClase { get; set; }
        internal int AtaqueClase { get; set; }
        internal int DefenseClase { get; set; }
        internal int VelocidadClase { get; set; }

        public Clase(string nombreClase,int vidaClase,int ataqueClase,int defensaClase,int velocidadClase) { 
            
            NombreClase = nombreClase;
            VidaClase = vidaClase;
            AtaqueClase = ataqueClase;
            DefenseClase = defensaClase;
            VelocidadClase = velocidadClase;

        
        }

    }
}
