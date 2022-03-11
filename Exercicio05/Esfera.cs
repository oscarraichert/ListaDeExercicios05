namespace Exercicio05
{
    public class Esfera
    {
        public double Raio;
        public double Pi;

        public Esfera(double raio)
        {
            Raio = raio;
            Pi = 3.14;
        }

        public double CalcularVolume()
        {
            double volume = 4 * Pi * (Raio * Raio * Raio) / 3;

            return volume;
        }

        public string MostrarVolume()
        {
            return $"O volume da esfera é {CalcularVolume()}m³";
        }
    }
}