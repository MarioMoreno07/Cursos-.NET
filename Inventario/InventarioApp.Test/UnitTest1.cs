using Inventario.Modelos;
using Inventario.Servicios;

namespace InventarioApp.Test {
    public class Tests {
        
        private InventarioService inventario;
        [SetUp]
        public void Setup() {
            inventario = new InventarioService();
        }

        [Test]
        public void TestAgregarProducto() {

            bool resultado = true;
            Proucto prd = new Proucto("unit","lapiz","utiles",1.2,100);
            Assert.That(inventario.AgregarProducto(prd),Is.EqualTo(resultado));
        }
      
        [Test]
        public void TestBuscarPorCodigo() {
            Proucto prd = new Proucto("unit", "lapiz", "utiles", 1.2, 100);
            inventario.AgregarProducto(prd);
            Assert.That(inventario.BuscarPorCodigo("unit"), Is.EqualTo(prd));
        }
        [Test]
        public void TestBuscarPorCategoria() {
            
            List<Proucto> list = new List<Proucto>();
            Proucto prd = new Proucto("unit", "lapiz","colegio", 1.2, 100);
            Proucto prd2 = new Proucto("01", "sacapuntas","colegio", 1.7, 100);
            inventario.AgregarProducto(prd);
            inventario.AgregarProducto(prd2);
            list = inventario.productos;
            Assert.That(inventario.BuscarPorCategoria("colegio"), Is.EqualTo(list));

        }
        [Test]
        public void TestReponerStock() {
            bool resultao = true;
            Proucto prd = new Proucto("unit", "lapiz", "utiles", 1.2, 100);
            inventario.AgregarProducto(prd);
            Assert.That(inventario.ReponerStock("unit",100),Is.EqualTo(resultao));
        }
        [Test]
        public void TestVenderProducto() {
            bool resultao = true;
            Proucto prd = new Proucto("unit", "lapiz", "utiles", 1.2, 100);
            inventario.AgregarProducto(prd);
            Assert.That(inventario.VenderProdcuto("unit", 20), Is.EqualTo(resultao));
        }
        [Test]
        public void TestCalcularValoTotal() {
            double resultado = 120;
            Proucto prd = new Proucto("unit", "lapiz", "utiles", 1.2, 100);
            inventario.AgregarProducto(prd);
            Assert.That(inventario.CalcularValorTotalInventario(), Is.EqualTo(resultado));
        }
        [Test]
        public void TestObtenerBajoStock() {
            List<Proucto> list = new List<Proucto>();
            Proucto prd = new Proucto("unit", "lapiz", "utiles", 1.2, 10);
            Proucto prd2 = new Proucto("01", "sacapuntas", "utiles", 1.7, 10);
            inventario.AgregarProducto(prd);
            inventario.AgregarProducto(prd2);
            list = inventario.productos;
            Assert.That(inventario.ObtenerBajoStock(20), Is.EqualTo(list));
        }



        [Test]
        public void TestExceptionNoDupli() {
            Proucto prd = new Proucto("unit", "lapiz", "utiles", 1.2, 100);
            inventario.AgregarProducto(prd);
            Proucto prd2 = new Proucto("unit", "sacapuntas", "utiles", 1.7, 100);
            Assert.Throws<ArgumentException>(() => inventario.AgregarProducto(prd2));
        }

        [Test]
        public void TestExceptionPrecioInvalido() {
            Proucto prd = new Proucto("unit", "lapiz", "utiles", -1.2, 100);
            Assert.Throws<ArgumentException>(() =>inventario.AgregarProducto(prd));
        }

        [Test]
        public void TestExceptionStockNegativo() {
            Proucto prd = new Proucto("unit", "lapiz", "utiles", 1.2, -100);
            Assert.Throws<ArgumentException>(() => inventario.AgregarProducto(prd));
        }
        [Test]
        public void TestExceptionStockInsuficeiente() {
            Proucto prd = new Proucto("unit", "lapiz", "utiles", 1.2, 10);
            inventario.AgregarProducto(prd);
            Assert.Throws<ArgumentException>(() => inventario.VenderProdcuto("unit",50));
        }
       
    }
}