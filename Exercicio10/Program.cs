using System;

namespace Exercicio10
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            CalculadorMediaPonderada calculadora = InserirDados();
            calculadora.CalcularMediaPonderada();
            Console.WriteLine(calculadora);
        }

        public static CalculadorMediaPonderada InserirDados()
        {
            decimal[] valores = new decimal[4];

            Console.WriteLine("Insira as notas para obter a média ponderada: \n");

            for (int i = 0; i < valores.Length; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                valores[i] = Convert.ToDecimal(Console.ReadLine());
            }

            CalculadorMediaPonderada calculador = new CalculadorMediaPonderada(valores);

            return calculador;
        }
    }
}
