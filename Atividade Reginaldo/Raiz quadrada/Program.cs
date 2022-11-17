using System;

namespace Raiz_quadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            Console.WriteLine("Digite um valor");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A raiz quadrada do número digitado é {0}" ,Math.Sqrt(numero));
            
        }
    }
}
