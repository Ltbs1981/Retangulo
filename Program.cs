using System;

namespace PerimetroRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a área, perímetro e a diagonal de um retângulo");
            Console.WriteLine("\nDigite a altura do retângulo");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo");
            double largura = double.Parse(Console.ReadLine());

            CalcR Calculador = new CalcR(altura, largura);

            Console.WriteLine(Calculador.ToString());
        }
    }
}
