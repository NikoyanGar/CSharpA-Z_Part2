namespace _001_IComparerContrvariance;
//хотя компаратор работает с Animal, его можно использовать для Dog.
internal class Program
{
    static void Main(string[] args)
    {
        List<Dog> dogs = new()
        {
            new Dog { Name = "Rex" },
            new Dog { Name = "Buddy" }
        };

        // Мы можем передать IComparer<Animal> в сортировку списка Dog,
        // потому что IComparer<in T> КОНТРАВАРИАНТЕН
        dogs.Sort(new AnimalNameComparer());

        foreach (var dog in dogs)
            Console.WriteLine(dog.Name);
    }
}
class Animal
{
    public string Name { get; set; }
}

class Dog : Animal { }

class AnimalNameComparer : IComparer<Animal>
{
    public int Compare(Animal x, Animal y) =>
        string.Compare(x.Name, y.Name, StringComparison.Ordinal);
}
