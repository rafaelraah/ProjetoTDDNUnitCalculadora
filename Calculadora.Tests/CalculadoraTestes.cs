using NUnit.Framework;

namespace Calculadora.Tests
{
    public class CalculadoraTestes
    {
        [TestFixture]
        public class CalculadoraSimplesTests
        {
            [Test]
            public void DeveAdicionarDoisNumeros()
            {
                //SUT = System Under Test
                var sut = new CalculadoraSimples();
                var resultado = sut.Adicionar(5,5);
                Assert.That(resultado, Is.EqualTo(10));
            }

            [Test]
            public void DeveMultiplicarDoisNumeros()
            {
                //SUT = System Under Test
                var sut = new CalculadoraSimples();
                var resultado = sut.Multiplicar(5, 3);
                Assert.That(resultado, Is.EqualTo(15));
            }

            [Test]
            public void DeveDividirDoisNumeros()
            {
                //SUT = System Under Test
                var sut = new CalculadoraSimples();
                var resultado = sut.Dividir(6, 2);
                Assert.That(resultado, Is.EqualTo(3));
            }
            [Test]
            public void DeveSubtrairDoisNumeros()
            {
                //SUT = System Under Test
                var sut = new CalculadoraSimples();
                var resultado = sut.Subtrair(5, 3);
                Assert.That(resultado, Is.EqualTo(2));
            }

        }
    }
}
