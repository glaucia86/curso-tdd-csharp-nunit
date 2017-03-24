using NUnit.Framework;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class CalculadoraTests
    {
        /* Método para testar se irá somar 2 números inteiros */
        [Test]
        public void DevoSomarNumerosInteiros()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarNumerosInteiros(4, 2);

            Assert.That(resultado, Is.EqualTo(6));
        }

        /* Método para testar se irá somar 2 números decimais */
        [Test]
        public void DevoSomarNumerosDecimais()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarNumerosDecimais(1.1, 2.2); //3.9

            Assert.That(resultado, Is.EqualTo(3.3));
        }


        /* Método para testar a tolerância de valores usando o método 'Within' */
        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithin()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarNumerosDecimais(1.1, 2.2); //3.3

            //Se o resultado estiver entre: 3,29 e 3,31 - teste ok!
            Assert.That(resultado, Is.EqualTo(3.3).Within(0.01)); 
        }

        /* Método para testar a tolerância de valores percentuais usando o método 'Within' */
        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithinPorcentagem()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarNumerosDecimais(50, 50); // 100%

            //Se o resultado estiver entre:  - teste ok!
            Assert.That(resultado, Is.EqualTo(101).Within(1).Percent); // tolerância de 1%
        }

        /* Método para mostrar o mal uso do método 'Within' - tolerância incorreta */
        [Test]
        public void DevoSomarNumerosDecimais_NaoBomExemploWithin()
        {
            var sut = new Calculadora();

            var resultado = sut.SomarNumerosDecimais(1.1, 2.2); //3.3

            // Ele não deveria passar
            Assert.That(resultado, Is.EqualTo(30).Within(100)); // em qq lugar entre: -70 a 130
        }

        /*
            - Is.Positive;
         *  - Is.Negative
         *  - Is.NaN;
         */

    }
}
