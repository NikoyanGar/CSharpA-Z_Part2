namespace _003_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "some animal";
            animal.Eat();
            Console.WriteLine(animal.Name);

            Dog dog = new Dog();
            dog.Name = "dog";
            dog.Bark();
            dog.Eat();
            Animal animal1 = dog;
            Console.WriteLine(animal1.Name);
        }
    }
}
