using NUnit.Framework;

namespace Demo_Asserts.Tests.BoleanosNulos
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        /* Método de Teste responsável por verificar se 
         * a propriedade 'Nome' está vazia ou não*/
        [Test]
        public void DevoGerarNomeRandomicoPorDefault()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Nome, Is.Not.Empty);
        }

        /* Método de Teste responsável por verificar se a propriedade 'NovoJogador' é 'true' */
        [Test]
        public void DevoVerificarNovoJogador()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.NovoJogador, Is.True);
        }

        /* Método de Teste responsável por verificar se a propriedade 'Apelido' é nulo ou não */
        [Test]
        public void DevoVerificarApelidoJogador()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Apelido, Is.Null);
        }
    }
}
