using System;
using System.Collections.Generic;

namespace Demo_Asserts
{
    public class CaracteristicasJogador
    {
        /* Atributos do Jogador */
        public int Vida { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public bool NovoJogador { get; set; }

        public List<string> Armas { get; set; }

        /* Classe Construtor */
        public CaracteristicasJogador()
        {
            Nome = GerarNome();

            NovoJogador = true;

            CriarArmasIniciais();
        }

        /* Método responsável por aumentar a vida do jogador */
        public void Dormir()
        {
            var random = new Random();

            // aumentar vida do jogador: 20/45/100
            var aumentarVida = random.Next(1, 101);

            Vida += aumentarVida;
        }

        /* Método responsável por tirar vida do jogador */
        public void PerderVida(int perderVida)
        {
            Vida = Math.Max(1, Vida -= perderVida);
        }

        /* Método responsável por gerar nomes dos jogadores de maneira randômica */
        public string GerarNome()
        {
            var nomes = new[]
            {
                "Spider-Man",
                "Homem de Ferro",
                "Capitão América",
                "Homem Formiga",
                "Hulk"
            };

            return nomes[new Random().Next(0, nomes.Length)];
        }

        /* Método responsável por listar armas disponíveis para o Jogador */
        private void CriarArmasIniciais()
        {
            Armas = new List<string>()
            {
                "Espada Grande",
                "Espada Curta",
                "Escudo",
                "Arco"
            };
        }
    }
}
