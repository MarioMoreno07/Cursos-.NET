using Calculadora;


namespace CalculadoraTest {
    public class CalculadoraClass {

        private CalculadoraApp calculadora;
        [SetUp]
        public void Setup() {
            calculadora = new CalculadoraApp();
        }

        [Test]
        public void Test1() {
            double resultado = 12;
            Assert.That(calculadora.Sumar(6,6) , Is.EqualTo(resultado));
        }
        [Test]
        public void Test2() {
            double resultado = 11;
            Assert.That(calculadora.Resta(14, 3), Is.EqualTo(resultado));
        }
        [Test]
        public void Test3() {
            double resultado = 18;
            Assert.That(calculadora.Multiplicar(9, 2), Is.EqualTo(resultado));
        }
        [Test]
        public void Test4() {
            double resultado = 6;
            Assert.That(calculadora.Dividir(12, 2), Is.EqualTo(resultado));
        }
        [Test]
        public void Test5() {
            double resultado = 4;
            Assert.That(calculadora.Potencia(2, 2), Is.EqualTo(resultado));
        }
        [Test]
        public void Test6() {
            double resultado = 7;
            Assert.That(calculadora.RaizCuadrada(49), Is.EqualTo(resultado));
        }
        [Test]
        public void Test7() {
            double resultado = 120;
            Assert.That(calculadora.Factorial(5), Is.EqualTo(resultado));
        }
        [Test]
        public void Test8() {
            double resultado = 2;
            Assert.That(calculadora.Porcentaje(10,20), Is.EqualTo(resultado));
        }
        [Test]
        public void Test9() {
            double[] numeros = [4, 8, 6];
            double resultado = 6;
            Assert.That(calculadora.Media(numeros), Is.EqualTo(resultado));
        }
        [Test]
        public void Test10() {
            double resultado = 0;
            Assert.That(calculadora.Modulo(12, 2), Is.EqualTo(resultado));
        }






        [Test]
        public void TestExceptionDivEntre0() {
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

        [Test]
        public void TestExceptionModEntre0() {
            Assert.Throws<DivideByZeroException>(() => calculadora.Modulo(10, 0));
        }

        [Test]
        public void TestExceptionFactorialNegativo() {
            Assert.Throws<ArgumentException>(() => calculadora.Factorial(-1));
        }
        [Test]
        public void TestExceptionRaizCuadradaNegativa() {
            Assert.Throws<ArgumentException>(() => calculadora.RaizCuadrada(-1));
        }

        [Test]
        public void TestExceptionMediaVacia() {
            double[] numeros = { };
            Assert.Throws<ArgumentNullException>(() => calculadora.Media(numeros));
        }



    }
}