namespace _003_IComparable
{
    public class Temperature : IComparable
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

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Temperature otherTemperature = obj as Temperature;
            if (otherTemperature != null)
            {
                return temperatureF.CompareTo(otherTemperature.temperatureF);
            }
            else
            {
                throw new ArgumentException("Object is not a Temperature");
            }
        }
    }
}
