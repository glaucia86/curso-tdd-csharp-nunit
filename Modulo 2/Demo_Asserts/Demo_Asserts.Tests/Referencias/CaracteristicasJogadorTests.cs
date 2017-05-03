using NUnit.Framework;

namespace Demo_Asserts.Tests.Referencias
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void CompararReferenciaDeObjetoComSameAs()
        {
            var jogador1 = new CaracteristicasJogador();
            var jogador2 = new CaracteristicasJogador();
            
            //Esse aqui irá falhar porque não estamos passando o mesmo
            // objeto de referência:
            Assert.That(jogador1, Is.SameAs(jogador2));
        }

        [Test]
        public void CompararReferenciaDeObjetoComVariavelSameAs()
        {
            var jogador1 = new CaracteristicasJogador();
            var jogador2 = new CaracteristicasJogador();

            var jogador = jogador1;
            Assert.That(jogador, Is.SameAs(jogador1));
        }
        
        [Test]
        public void ComporarReferenciaDeObjetoComIsNotSameAs()
        {
            var jogador1 = new CaracteristicasJogador();
            var jogador2 = new CaracteristicasJogador();

            Assert.That(jogador1, Is.Not.SameAs(jogador2));
        }

    }
}
