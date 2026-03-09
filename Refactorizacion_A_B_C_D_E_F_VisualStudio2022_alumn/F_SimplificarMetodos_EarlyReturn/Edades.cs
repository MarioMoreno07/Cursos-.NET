using System;


namespace RefactorF {
    class Edades {

        public string ClasificarEdad(int e) {
            if (e < 0) {return "No puede ser menor a 0";} 
            else if (e >= 0 && e <18) {return "Es menor";}
            return "Es mayor";
        }
    }
}
