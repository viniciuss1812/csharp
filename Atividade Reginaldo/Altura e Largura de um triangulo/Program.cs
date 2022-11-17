using System;

namespace Altura_e_Largura_de_um_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura;
            double altura;
            double perimetro;
            double area;

            Console.WriteLine("Informe a largura");
            largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a altura");
            altura = Convert.ToDouble(Console.ReadLine());


          
            perimetro = largura + largura + altura + altura;
            area = largura * altura;
            Console.WriteLine("O valor do perímetro é {0}" ,perimetro);
            Console.WriteLine("O valor da área é {0}", area);

        }
    }
}
