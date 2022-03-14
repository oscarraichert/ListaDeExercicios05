namespace Exercicio10
{
    internal partial class Program
    {
        public class CalculadorMediaPonderada
        {
            public decimal[] Valores;
            public decimal Media;

            public CalculadorMediaPonderada(decimal[] valores)
            {
                Valores = valores;
            }

            public override string ToString()
            {
                return $"A média ponderada das notas é: {Media}";
            }

            public decimal CalcularMediaPonderada()
            {
                decimal valorAtual = 0;
                for (int i = 0; i < Valores.Length; i++)
                {
                    valorAtual += Valores[i];
                }

                Media = valorAtual / Valores.Length;
                return Media;
            }
        }
    }
}
