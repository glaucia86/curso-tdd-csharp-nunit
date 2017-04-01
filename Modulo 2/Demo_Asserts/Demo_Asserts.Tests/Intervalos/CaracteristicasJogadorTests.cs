using NUnit.Framework;

namespace Demo_Asserts.Tests.Intervalos
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        /* Método de teste responsável por testar se o jogador está ganhando 
         * vida depois que dormiu */
        [Test]
        public void DevoAumentarVidaJogadorDepoisDormir()
        {
            // vida inicial do jogador = 100%
            var sut = new CaracteristicasJogador { Vida = 100 };

            sut.Dormir();

            Assert.That(sut.Vida, Is.GreaterThan(100));
        }

        /* Método de teste responsável por testar se o jogador está ganhando 
         * vida depois que dormiu, porém usando intervalos/faixas de valores */
        [Test]
        public void DevoAumentarVidaJogadorDepoisDormir_Intervalo()
        {
            var sut = new CaracteristicasJogador { Vida = 100 };

            sut.Dormir();

            Assert.That(sut.Vida, Is.InRange(101, 200));
        }

        /* 
         *  1) Is.GreaterThanOrEqualTo() <= 100
            2) Is.LessThan() > 100
         *  3) Is.LessThanOrEqualTo() = > 100
         *  
         */
    }
}
