using System;


namespace RefactorF {
    class Edades {

        public string ClasificarEdad(int e) {
            string r = "";
            if (e < 0) {r= "No puede ser menor a 0";} 
            else if (e >= 0 && e <18) {r= "Es menor";}
            else r= "Es mayor";

            return r;
        }
    }
}
