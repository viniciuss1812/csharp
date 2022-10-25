using System;

namespace Tipos_de_Variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = num1;
            int resultado = num1 + num2;
            num1 = 6;
            Console.WriteLine("Valor de num1 é: {0} e está na stack", num1.ToString());
            Console.WriteLine("Valor de num2 é: {0} e está na stack", num2.ToString());

            Console.WriteLine("Calculadora");
            Calculadora minhacalculadora = new Calculadora();
            minhacalculadora.somar();

            Console.WriteLine("Variáveis Nulla");
            int?  altura = null;

            if (altura.HasValue)
            {
                Console.WriteLine("O valor é: {0}:", altura);

            }
            else
            {
                Console.WriteLine("Altura está nullo");

            }

            Console.ReadKey();
        }

    }
}
