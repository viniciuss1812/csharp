using System;

namespace Inteiro_ou_real
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            Console.WriteLine("Digite um valor");
            try
            {
                valor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("O valor é inteiro");
            }
            catch (Exception)
            {
                Console.WriteLine("O valor digitado é real");
                
            }
           
        }
    }
}
