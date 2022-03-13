using System;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadorDeMh calculadorMh = InserirNotas();
            calculadorMh.CalcularMedia();
            Console.WriteLine(calculadorMh);
        }

        public static CalculadorDeMh InserirNotas()
        {
            decimal[] valores = new decimal[4];

            Console.WriteLine("Insira as notas para receber a média harmônica: \n");

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                valores[i] = Convert.ToDecimal(Console.ReadLine());
            }

            CalculadorDeMh calculadorMh = new CalculadorDeMh(valores);

            return calculadorMh;
        }
    }
}