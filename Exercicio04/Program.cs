using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Combustivel combustivel = PegarDados();
            Console.Write(combustivel.MostrarConsumo());
        }
        public static Combustivel PegarDados()
        {
            while (true)
            {
                Console.WriteLine("Informe os dados do veículo: ");

                Console.Write("\nQuilometragem inicial: ");
                double kmI = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quilometragem final: ");
                double kmF = Convert.ToDouble(Console.ReadLine());

                if (kmI > kmF)
                {
                    Console.WriteLine("A quilometragem inicial não pode ser maior do que a final!\n");
                    continue;
                }

                Console.Write("Combustível inicial (em litros): ");
                double combustivelI = Convert.ToDouble(Console.ReadLine());

                Console.Write("Combustível final (em litros): ");
                double combustivelF = Convert.ToDouble(Console.ReadLine());

                if (combustivelI < combustivelF)
                {
                    Console.WriteLine("O combustivel final não pode ser maior do que o inicial!\n");
                    continue;
                }

                Combustivel combustivel = new Combustivel(kmI, kmF, combustivelI, combustivelF);
                return combustivel;
            }
        }
    }
}