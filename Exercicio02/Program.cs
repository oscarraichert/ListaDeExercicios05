using System;

namespace Exercicio02
{

    internal class Program
    {
        public static double temp = 0;

        static void Main(string[] args)
        {
            int opcao = 0;


            while (opcao != 3)
            {
                Console.Clear();
                Console.WriteLine("Selecione o método de conversão: \n");

                Console.WriteLine("(1) para converter graus Celsius para Fahrenheit.");
                Console.WriteLine("(2) para converter graus Fahrenheit para Celsius.");
                Console.WriteLine("(3) para sair");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("\nDigite a temperatura (em ºC): ");
                        temp = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        Temperatura temperaturaC = new Temperatura(temp);
                        Console.WriteLine(temperaturaC.ConverterParaFahrenheit());
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.Write("\nDigite a temperatura (em ºF): ");
                        temp = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        Temperatura temperaturaF = new Temperatura(temp);
                        Console.WriteLine(temperaturaF.ConverterParaCelsius());
                        Console.ReadKey();

                        break;

                    case 3:
                        break;
                }
            }
        }
    }
}