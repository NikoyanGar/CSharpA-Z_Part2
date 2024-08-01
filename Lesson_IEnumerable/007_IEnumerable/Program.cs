namespace _007_IEnumerable
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a zoo
            //var zoo = new Zoo();
            //zoo.AddAnimal("Simba", "Lion");
            //zoo.AddAnimal("Giraffey", "Giraffe");
            //zoo.AddAnimal("Dumbo", "Elephant");

            //Console.WriteLine("Welcome to the Zoo!");
            //foreach (var animal in zoo)
            //{
            //    Console.WriteLine($"You encounter a {animal.Species}: {animal.Name}");
            //}


            var zoo1 = new ZooNotGeneric();
            zoo1.AddAnimal("Simba", "Lion");
            zoo1.AddAnimal("Giraffey", "Giraffe");
            zoo1.AddAnimal("Dumbo", "Elephant");

            Console.WriteLine("Welcome to the Zoo!");
            foreach (var animalobject in zoo1)
            {
                Animal animal = (Animal)animalobject;
                Console.WriteLine($"You encounter a {animal.Species}: {animal.Name}");
            }
        }
    }
}
