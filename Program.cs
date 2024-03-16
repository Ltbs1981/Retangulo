using System;

namespace PerimetroRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a área, perímetro e a diagonal  de um retângulo");
            Console.WriteLine("\nDigite a altura do retângulo");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retângulo");
            double largura = double.Parse(Console.ReadLine());

            CalcR Calculador = new CalcR();
            Calculador.altura = altura;
            Calculador.largura = largura;

            double perimetro = Calculador.CalculandoPerimetro();
            double area = Calculador.CalculandoArea();
            double diagonal = Calculador.CalculandoDiagonal();
            perimetro = Math.Round(perimetro, 2);
            area = Math.Round(area, 2);
            diagonal = Math.Round(diagonal, 2);

            Console.WriteLine($"Perímetro: {perimetro}");
            Console.WriteLine($"Área: {area}");
            Console.WriteLine($"Diagonal: {diagonal}");
        }
    }
}
