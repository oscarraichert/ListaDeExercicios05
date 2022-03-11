using System;

namespace Exercicio01
{
    public class Caixa
    {
        public double Altura;
        public double Largura;
        public double Profundidade;

        public Caixa(double altura, double largura, double profundidade)
        {
            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;
        }

        public void CalcularVolume()
        {
            double volume = Altura * Largura * Profundidade;
            Caixa caixa = new Caixa(Altura, Largura, Profundidade);

            Console.WriteLine($"\nO Volume da caixa é {volume}m³");
        }
    }
}