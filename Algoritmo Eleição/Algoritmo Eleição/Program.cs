using System;

namespace Algoritmo_Eleição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleições 2022");
            int qntCadn26 = 0;
            int qntCadn44 = 0;
            int qntCadn56 = 0;
            int qntnulo = 0;
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Informe o seu nome");
                string nome = Console.ReadLine();
                Console.WriteLine("Vote em um dos candidatos a seguir");
                Console.WriteLine("26 - João");
                Console.WriteLine("44 - Maria");
                Console.WriteLine("56 - Tabet");
                Console.WriteLine("0 - Nulo");
                Console.WriteLine("Digite o número");
                int meuvoto = Convert.ToInt32(Console.ReadLine());

                if (meuvoto == 26) { qntCadn26 = qntCadn26 + 1; }
                else if (meuvoto == 44) { qntCadn44 = qntCadn44 + 1; }
                else if (meuvoto == 56) { qntCadn56 = qntCadn56 + 1; }
                else qntnulo = qntnulo + 1;

                Console.WriteLine("Deseja continuar? { sim  / não }");
                string resposta = Console.ReadLine(); 




            }


        }
    }
}
