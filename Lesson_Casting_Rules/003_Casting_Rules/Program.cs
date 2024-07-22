namespace _003_Casting_Rules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Cat();// Implicit upcasting
            Cat myCat = (Cat)myAnimal; // Explicit downcasting
        }
    }
}
