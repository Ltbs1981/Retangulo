using System;

namespace PerimetroRetangulo
{
    class CalcR
    {
        public double altura;
        public double largura;

        public double CalculandoPerimetro()
        {
            return (largura + altura) * 2;
        }

        public double CalculandoArea()
        {
            return largura * altura;
        }

        public double CalculandoDiagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
    }
}
