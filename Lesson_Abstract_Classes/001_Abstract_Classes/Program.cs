namespace _001_Abstract_Classes
{
    //Declaration: An abstract class is declared using the abstract keyword.
    //Abstract Methods: These are methods declared in an abstract class without any implementation.
    //Derived classes must override these methods.
    //Concrete Methods: Abstract classes can also have fully implemented methods.
    //Inheritance: Abstract classes are intended to be inherited by other classes.
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] { new Cat(), new Dog() };
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"The {animal.GetType().Name} goes {animal.Sound}");
                animal.Move();
            }
        }
    }
    public abstract class Animal
    {
        public abstract string Sound { get; }
        public virtual void Move()
        {
            Console.WriteLine("Moving...");
        }
    }

    public class Cat : Animal
    {
        public override string Sound => "Meow";
        public override void Move()
        {
            Console.WriteLine("Walking like a cat...");
        }
    }

    public class Dog : Animal
    {
        public override string Sound => "Woof";
        public override void Move()
        {
            Console.WriteLine("Running like a dog...");
        }
    }
}
