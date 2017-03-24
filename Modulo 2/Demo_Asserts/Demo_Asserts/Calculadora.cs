using System;

namespace Demo_Asserts
{
    public class Calculadora
    {
        /* Método para Somar Inteiros */
        public int SomarNumerosInteiros(int num1, int num2)
        {
            return num1 + num2;
        }

        /* Método para Somar Decimais */
        public double SomarNumerosDecimais(double num1, double num2)
        {
            return num1 + num2;
        }


        /* Método para Dividir */
        public int Dividir(int num, int por)
        {
            if (num > 100)
            {
                throw new ArgumentOutOfRangeException("por"); //propositos para a demo
            }

            return num / por;
        }
    }
}
