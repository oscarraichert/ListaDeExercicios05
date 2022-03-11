using System;

namespace Exercicio01
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Altura da caixa (em m): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Largura da caixa (em m): ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Profundidade da caixa (em m): ");
            double profundidade = Convert.ToDouble(Console.ReadLine());

            Caixa caixa = new Caixa(altura, largura, profundidade);
            caixa.CalcularVolume();
        }
    }
}