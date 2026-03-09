using System;

namespace SOLID_LSP
{

    public class Pinguino : Ave
    {
        public string nombre;
        public Pinguino(string nombre): base(nombre) {
            nombre = nombre;
        }

        public override void Moverse()
        {
            Console.WriteLine("Se mueve andando");
        }
    }
}