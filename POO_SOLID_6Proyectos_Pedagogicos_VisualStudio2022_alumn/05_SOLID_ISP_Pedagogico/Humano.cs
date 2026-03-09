using System;


namespace SOLID_ISP
{
     class Humano : IComedor, ITrabajador
    {

        public string nombre { get; set; }
        public Humano(string nombre) {
            nombre = nombre;
        }
        public void Comer()
        {
            Console.WriteLine("El humano come");
        }

        public void Trabajar()
        {
            Console.WriteLine("El humano trabaja");
        }
    }
}
