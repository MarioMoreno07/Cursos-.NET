using System;

namespace SOLID_LSP
{

    public class Pinguino : Ave
    {
        public Pinguino(string nombre): base(nombre) { }

        public override void Moverse()
        {
            Console.WriteLine("Se mueve andando");
        }
    }
}