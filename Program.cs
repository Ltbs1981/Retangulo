using System;

namespace PerimetroRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a área de um retângulo");
            Console.WriteLine("\nDigite a altura do retângulo");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo");
            double largura = double.Parse(Console.ReadLine());

            double perimetro = CalculandoPerimetro(altura, largura);
            double area = CalculandoArea(altura, largura);
            double diagonal = CalculandoDiagonal(altura, largura);
            diagonal = Math.Round(diagonal, 2);


            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Diagonal: {diagonal}");
        }

        public static double CalculandoPerimetro(double altura, double largura)
        {
            return 2 * (largura + altura);
        }

        public static double CalculandoArea(double altura, double largura)
        {
            return largura * altura;
        }

        public static double CalculandoDiagonal(double altura, double largura)
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
    }
}
