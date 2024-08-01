using System.Collections;

namespace _007_IEnumerable
{
    // Zoo class representing the collection of animals
    public class Zoo : IEnumerable<Animal>
    {
        private readonly List<Animal> animals = new List<Animal>();

        public void AddAnimal(string name, string species)
        {
            animals.Add(new Animal { Name = name, Species = species });
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            //yield return new Animal { Name = "Lion", Species = "Panthera leo" };
            return new Zookeeper(animals);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
