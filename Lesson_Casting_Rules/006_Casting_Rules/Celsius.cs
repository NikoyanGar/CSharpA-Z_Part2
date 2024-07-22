namespace _006_Casting_Rules
{
    public class Celsius
    {
        public double Degrees { get; set; }

        public static implicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit { Degrees = (c.Degrees * 9 / 5) + 32 };
        }
    }
}
