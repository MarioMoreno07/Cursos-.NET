using System;


namespace RefactorD {
    class Pedido {

       private Cliente Usuario { get; set; }
        private int Precio { get; set; }


        public Pedido(Cliente usuario, int precio) {
            Usuario = usuario;
            Precio = precio;
        }

        public int Total() {
            return Precio;
        }

        public double TotalFinal() {
            return Usuario.CalcularDescuento(Precio);
        }
    }
}
