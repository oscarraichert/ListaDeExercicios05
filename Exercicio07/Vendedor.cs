namespace Exercicio07
{
    public class Vendedor
    {
        public decimal SalarioBase;
        public decimal TotalVendas;
        public decimal PercentualComissao;
        public decimal ValorComissao;
        public decimal SalarioFinal;

        public Vendedor(decimal salarioBase, decimal totalVendas, decimal percentualComissao)
        {
            SalarioBase = salarioBase;
            TotalVendas = totalVendas;
            PercentualComissao = percentualComissao;
            ValorComissao = TotalVendas * (PercentualComissao / 100);
        }

        public decimal CalcularSalario()
        {
            SalarioFinal = ValorComissao + SalarioBase;
            
            return SalarioFinal;
        }

        public string MostrarSalario()
        {
            return $"O salário total foi R${SalarioFinal}";
        }
    }
}