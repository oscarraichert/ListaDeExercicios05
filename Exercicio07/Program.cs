using System;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor vendedor = Input();
            vendedor.CalcularSalario();
            Console.WriteLine(vendedor.MostrarSalario());
        }

        static Vendedor Input()
        {
            Console.WriteLine("Cálculo do salário do vendedor: \n");
            
            Console.Write("Informe o salário base: R$");
            decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o valor total das vendas: R$");
            decimal valorVendas = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o percentual (%) da comissao: ");
            decimal percentualComissao = Convert.ToDecimal(Console.ReadLine());

            Vendedor vendedor = new Vendedor(salarioBase, valorVendas, percentualComissao);
            return vendedor;
        }
    }
}