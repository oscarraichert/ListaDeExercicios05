namespace Exercicio03
{
    public class Cilindro
    {
        public double Pi;
        public double Raio;
        public double Altura;
        public double Volume;

        public Cilindro(double raio, double altura)
        {
            Pi = 3.1;
            Raio = raio;
            Altura = altura;
        }

        public double CalcularVolume()
        {
            Volume = Pi * (Raio * Raio) * Altura;

            return Volume;
        }


        public string MostrarVolume()
        {
            return $"O volume do cilindro é {Volume}m³\n";
        }
    }
}
