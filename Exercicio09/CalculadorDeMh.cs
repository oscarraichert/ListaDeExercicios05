using System;
using System.Linq;

namespace Exercicio09
{
    public class CalculadorDeMh
    {
        public decimal[] Valores;
        public decimal Media;

        public CalculadorDeMh(decimal[] valores)
        {
            Valores = valores;
        }

        public override string ToString()
        {
            return $"\nMédia Harmônica das notas: {Math.Round(Media, 2)}";
        }

        public decimal CalcularMMC()
        {
            decimal maiorNumero = Valores.Max();

            for (int i = 1; i < maiorNumero; i++)
            {
                multiplicador = maiorNumero * i;
                if (Valores.All(ValorDivisivel))
                {                    
                    return multiplicador;
                }
            }

            return -1;
        }

        public decimal CalcularMedia()
        {
            for (int i = 0; i < Valores.Length; i++)
            {
                Valores[i] = multiplicador / Valores[i];
            }

            decimal soma = 0;
            foreach (decimal valor in Valores)
            {
                soma += valor;
            }

            return Media = Valores.Length * (multiplicador / soma);
        }

        decimal multiplicador = 1;

        public bool ValorDivisivel(decimal valor)
        {            
            return multiplicador % valor == 0;
        }
    }
}