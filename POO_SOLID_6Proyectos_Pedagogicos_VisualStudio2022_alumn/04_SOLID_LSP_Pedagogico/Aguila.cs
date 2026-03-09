using System;

namespace SOLID_LSP
{

	public class Aguila : Ave,IAveVoladora
	{
		public Aguila(string nombre) : base(nombre) { }

    public override void Moverse()
        {
            Console.WriteLine("Se mueve volando");
        }

        public void Volar()
        {
            Console.WriteLine("Vuela");
        }
    }
}