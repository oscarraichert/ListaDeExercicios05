using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = CriarCilindro();

            cilindro.CalcularVolume();

            Console.WriteLine();
            Console.Write(cilindro.MostrarVolume());            
        }

        public static Cilindro CriarCilindro()
        {
            Console.WriteLine("Cálculo de volume do cilindro: ");

            Console.Write("\nInsira o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Cilindro cilindro = new Cilindro(raio, altura);

            return cilindro;
        }
    }
}