using NUnit.Framework;

namespace Demo_Asserts.Tests.Igualdade
{
    [TestFixture]
    public class JuntarNomesTests
    {
        /* Método responsável por juntar duas strings */
        [Test]
        public void DevoJuntarNomeCompleto()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("Glaucia", "Lemos");

            Assert.That(nomeCompleto, Is.EqualTo("Glaucia Lemos"));
        }

        /* Método responsável por juntar duas strings - case sensitive */
        [Test]
        public void DevoJuntarNomeCompleto_CaseSensitive()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("glaucia", "lemos");

            Assert.That(nomeCompleto, Is.EqualTo("GLAUCIA LEMOS").IgnoreCase);
        }

        /* Método responsável por juntar duas strings - quando strings não são iguais */
        [Test]
        public void DevoJuntarNomeCompleto_NaoIgual()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("Glaucia", "Lemos");

            Assert.That(nomeCompleto, Is.Not.EqualTo("Jose Lemos"));
        }
    }
}
