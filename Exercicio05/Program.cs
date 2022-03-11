using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esfera esfera = ColetarDados();

            esfera.CalcularVolume();
            Console.WriteLine(esfera.MostrarVolume());
        }

        static Esfera ColetarDados()
        {
            Console.Write("Informe o raio da esfera (em metros): ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Esfera esfera = new Esfera(raio);

            return esfera;
        }
    }
}