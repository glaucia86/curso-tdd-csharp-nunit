using NUnit.Framework;

namespace Demo_Asserts.Tests.Colecoes
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        //Método responsável por testar se a lista de uma determinada coleção está vazia:
        [Test]
        public void NaoDevoTerListaDeArmasVazia()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Is.All.Not.Empty);
        }


        //Método responsável por testar se contem um determinado item na coleção:
        [Test]
        public void DeveTerArmaTeiaDeAranha()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Contains.Item("Teia de Aranha"));
        }

        //Método responsável por testar se contem uma determinada palavra em uma determinada coleção:
        [Test]
        public void DeveConterPeloMenosUmTipoDeArtificial()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Has.Some.Contains("Artificial"));
        }


        //Método responsável por testar se tem um número específico de determinados itens:
        [Test]
        public void DeveConterDuasArmasDeForca()
        {
            var sut =  new CaracteristicasJogador();

            Assert.That(sut.Armas, Has.Exactly(2).EndWith("Força"));
        }

        //Método responsável por testar se os itens contidos na lista são únicos:
        [Test]
        public void NaoDeveContarMaisTiposDeArmasNoJogo()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Is.Unique);
        }

        //Método responsável por testar se há algum item que não está listado na coleção:
        [Test]
        public void NaoDeveConterArmaVoar()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Has.None.EqualTo("Voar"));
        }

        //Método responsável por testar se há equivalência de itens na coleção:
        [Test]
        public void DeveConterExamenteTodasAsArmas()
        {
            var sut = new CaracteristicasJogador();

            var listaArmasEsperadas = new[]
            {
                "Agilidade",
                "Força",
                "Agilidade Força",
                "Teia de Aranha",
                "Inteligência Artificial"
            };

            Assert.That(sut.Armas, Is.EquivalentTo(listaArmasEsperadas));
        }


        //Método responsável por testar se a coleção está em ordem alfabética:
        [Test]
        public void ArmasDevemEstarOrdemAlfabetica()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Is.Ordered);
        }
    }
}
