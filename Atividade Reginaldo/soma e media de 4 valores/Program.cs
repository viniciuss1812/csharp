using System;

namespace soma_e_media_de_4_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeros1 = 0;
            double numeros2 = 0;
            double numeros3 = 0;
            double numeros4 = 0;
            double media;
            double soma;
            Console.WriteLine("Digite 4 valores");
            numeros1 = Convert.ToDouble(Console.ReadLine());
            numeros2 = Convert.ToDouble(Console.ReadLine());
            numeros3 = Convert.ToDouble(Console.ReadLine());
            numeros4 = Convert.ToDouble(Console.ReadLine());
            soma = numeros1 + numeros2 + numeros3 + numeros4;
            media = soma / 4;
            Console.WriteLine("O valor da soma é "+soma+ " e o valor da média é " +media);


        }
    }
}
