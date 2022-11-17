using System;

namespace Atividade_Reginaldo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número");


            try
            {
              double numero = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("O valor digitado é um número");
            }
            catch (Exception)
            {
                Console.WriteLine("O valor digitado não é número");
              
            }


        }
    }
}
