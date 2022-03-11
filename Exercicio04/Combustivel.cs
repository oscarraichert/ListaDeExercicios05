namespace Exercicio04
{
    public class Combustivel
    {
        public double KmInicial;
        public double KmFinal;
        public double CombustivelInicial;
        public double CombustivelFinal;

        public Combustivel(double kmInicial, double kmFinal, double combustivelInicial, double combustivelFinal)
        {
            KmInicial = kmInicial;
            KmFinal = kmFinal;
            CombustivelInicial = combustivelInicial;
            CombustivelFinal = combustivelFinal;
        }

        public double DistanciaPercorrida()
        {
            double distancia = KmFinal - KmInicial;

            return distancia;
        }

        public double ConsumoTotal()
        {
            double consumo = CombustivelInicial - CombustivelFinal;

            return consumo;
        }

        public double ConsumoPorKm()
        {
            double consumoKm = ConsumoTotal() / DistanciaPercorrida();

            return consumoKm;
        }

        public string MostrarConsumo()
        {
            return $"O veículo consumiu uma média de {ConsumoPorKm()} litros por km\n";
        }
    }
}