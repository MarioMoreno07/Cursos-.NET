using System;


namespace SOLID_ISP
{
    public class Humano : IComedor, ITrabajador
    {

        public string nombre { get; set; }
        public Humano(string nombre) { }
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
