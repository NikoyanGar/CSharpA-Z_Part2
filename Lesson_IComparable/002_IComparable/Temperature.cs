namespace _002_IComparable
{
    public class Temperature
    {
        // The temperature value
        protected double temperatureF;

        public double Fahrenheit
        {
            get
            {
                return temperatureF;
            }
            set
            {
                temperatureF = value;
            }
        }

        public double Celsius
        {
            get
            {
                return (temperatureF - 32) * (5.0 / 9);
            }
            set
            {
                temperatureF = value * 9.0 / 5 + 32;
            }
        }
    }
}
