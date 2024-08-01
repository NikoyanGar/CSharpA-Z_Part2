using System.Collections;

namespace _007_IEnumerable
{
    // Zoo class representing the collection of animals
    public class ZooNotGeneric : IEnumerable
    {
        private readonly List<Animal> animals = new List<Animal>();

        public void AddAnimal(string name, string species)
        {
            animals.Add(new Animal { Name = name, Species = species });
        }

        public IEnumerator GetEnumerator()
        {
            return new ZookeeperNotGeneric(animals);
        }
    }
}
