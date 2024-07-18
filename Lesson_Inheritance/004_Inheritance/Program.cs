namespace _004_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Demonstration of inheritance
            Animal[] animals = new Animal[5];

            Dog dog1 = new Dog();
            dog1.Name = "Buddy";
            animals[0] = dog1;

            Dog dog2 = new Dog();
            dog2.Name = "Max";
            animals[1] = dog2;

            Dog dog3 = new Dog();
            dog3.Name = "Charlie";
            animals[2] = dog3;

            Cat cat1 = new Cat();
            cat1.Name = "Whiskers";
            animals[3] = cat1;

            Cat cat2 = new Cat();
            cat2.Name = "Mittens";
            animals[4] = cat2;

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);

                if (animal is Dog)
                {
                    Dog? dog = animal as Dog;
                    dog?.Bark();
                }
                else if (animal is Cat)
                {
                    Cat? cat = animal as Cat;
                    cat?.Meow();
                }
                animal.Eat();

            }
        }
    }
}
