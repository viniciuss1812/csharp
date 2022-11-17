using System;

namespace programa_que_leia_o_quadrado_e_exiba_o_perímetro
{
    class Program
    {
        static void Main(string[] args)
        {
            double lados = 0;
            Console.WriteLine("Informe o lados do quadrado");
            lados = Convert.ToDouble(Console.ReadLine());
            lados = lados + lados+ lados + lados;
            Console.WriteLine("O perímetro do quadrado é {0}" ,lados);
        }
    }
}
