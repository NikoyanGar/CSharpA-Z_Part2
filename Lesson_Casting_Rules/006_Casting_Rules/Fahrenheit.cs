namespace _006_Casting_Rules
{
    public class Fahrenheit
    {
        public double Degrees { get; set; }

        public static implicit operator Celsius(Fahrenheit f)
        {
            return new Celsius { Degrees = (f.Degrees - 32) * 5 / 9 };
        }
    }
}
