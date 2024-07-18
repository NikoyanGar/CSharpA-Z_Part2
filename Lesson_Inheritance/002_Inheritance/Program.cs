namespace _002_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog { Name = "Rover" };
            dog.Eat();
            dog.Bark();

            var cat = new Cat { Name = "Whiskers" };
            cat.Eat();
            cat.Meow();
        }
    }
}
