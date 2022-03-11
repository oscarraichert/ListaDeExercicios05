namespace Exercicio02
{
    public class Temperatura
    {
        public double Temp;

        public Temperatura(double temp)
        {
            Temp = temp;
        }

        public string ConverterParaFahrenheit()
        {            
            double tempF = (Temp * 9/5) +32;

            return $"A temperatura é {tempF}ºF"; ;
        }

        public string ConverterParaCelsius()
        {
            double tempF = (Temp - 32) * 5/9;

            return $"A temperatura é {tempF}ºC";
        }
    }
}