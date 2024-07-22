namespace _004_Casting_Rules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Cat();
            Cat? myCat = myAnimal as Cat;
            if (myCat != null)
            {
                Console.WriteLine("Casting succeeded.");
            }
            else
            {
                Console.WriteLine("Casting failed.");
            }
        }
    }
}
