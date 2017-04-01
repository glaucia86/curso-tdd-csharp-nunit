using System;
using NUnit.Framework;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class DatasEspeciaisStoreTests
    {
        /* Método de Teste responsável por testar se é realmente um ano novo */
        [Test]
        public void DeveRetornarCorretamenteAnoNovo()
        {
            var sut = new DatasEspeciaisStore();

            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            Assert.That(resultado, Is.EqualTo(new DateTime(2017,1,1,0,0,0,0)));
        }

        /* Método de Teste responsável por testar se é realmente um ano novo */
        [Test]
        public void DeveRetornarCorretamenteAnoNovo_Within()
        {
            var sut = new DatasEspeciaisStore();

            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            //Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 1)).Within(1).Milliseconds);

            // Outra forma de fazer:
            Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 1))
                .Within(TimeSpan.FromMilliseconds(1)));
        }
    }
}
