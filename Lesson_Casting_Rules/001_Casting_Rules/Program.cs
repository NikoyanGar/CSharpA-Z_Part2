namespace _001_Casting_Rules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Implicit Casting
            int myInt = 9;
            double myDouble = myInt; // Implicit casting: int to double
            Console.WriteLine(myDouble); // Outputs 9.0

            //2.Explicit Casting/manually/Explicit casting is required when information might be lost in the conversion, or when the conversion might not succeed for other reasons.
            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble1; // Explicit casting: double to int
            Console.WriteLine(myInt1); // Outputs 9
        }
    }
}
