using System;

namespace PerimetroRetangulo
{
    class CalcR
    {
        public double Altura;
        public double Largura;

        public CalcR(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double CalculandoPerimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double CalculandoArea()
        {
            return Largura * Altura;
        }

        public double CalculandoDiagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            double perimetro = Math.Round(CalculandoPerimetro(), 2);
            double area = Math.Round(CalculandoArea(), 2);
            double diagonal = Math.Round(CalculandoDiagonal(), 2);
            return $"A área é: {area} \nO perímetro é: {perimetro} \nA diagonal é: {diagonal}";
        }
    }
}
