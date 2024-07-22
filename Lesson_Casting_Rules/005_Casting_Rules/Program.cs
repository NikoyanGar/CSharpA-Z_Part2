namespace _005_Casting_Rules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Cat();
            if (myAnimal is Cat myCat)
            {
                myCat.DoSomething();
                Console.WriteLine("Casting succeeded.");
            }
            else
            {
                Console.WriteLine("Casting failed.");
            }
        }
    }
}
