namespace _002_Inheritance
{
    class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meow!");
        }
    }
}
