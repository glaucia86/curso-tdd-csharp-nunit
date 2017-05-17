using System;
using NUnit.Framework;

namespace Demo_Asserts.Tests.Excecoes
{
    [TestFixture]
    public class CalculadoraTests
    {
        [Test]
        //Método de Teste que permite verificar se o número for dividido por zero deverá retornar uma exceção.
        public void DeveRetornarErroQuandoDividirPorZero()
        {
            var sut = new Calculadora();

            Assert.That(() => sut.Dividir(200, 0), Throws.Exception);
        }

        [Test]
        //Método de teste que irá verificar o tipo de exceção que está sendo retornada quando o 
        //número for dividido por zero.. 
        public void DeveRetornarErroQuandoDividirPorZero_MelhorCaso()
        {
            var sut = new Calculadora();

            Assert.That(() => sut.Dividir(99, 0), Throws.TypeOf<DivideByZeroException>());
        }
       
        [Test]
        //Método de teste que irá verificar a condição se o número dividido é maior do que cem. 
        public void DeveRetornarErroQuandoNumeroMaiorDoQueCem()
        {
            var sut = new Calculadora();

            Assert.That(() => sut.Dividir(200, 2), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        //Método de teste que irá verificar a condição se o número dividido é maior do que cem e
        //também o parâmetro informado no método principal
        public void DeveRetornarErroQuandoNumeroMaiorDoQueCem_MelhorCaso()
        {
            var sut = new Calculadora();

            Assert.That(() => sut.Dividir(200, 2), 
                Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Matches<ArgumentOutOfRangeException>(v => v.ParamName == "por"));
        }
    }
}
