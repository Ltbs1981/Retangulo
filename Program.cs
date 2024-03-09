using System;

namespace PerimetroRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a área de um retângulo");
            Console.WriteLine("\nDigite a altura do retângulo");
            double altura = double.Parse(Console.ReadLine()) ;

            Console.WriteLine("Digite a largura do retângulo");
            double largura = double.Parse(Console.ReadLine()) ;

            double perimetro = 2 * (largura + altura);
            double area = largura * altura;
            double diagonal = Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));

            diagonal = Math.Round(diagonal, 2);

            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Diagonal: {diagonal}");
        }
    }
}
