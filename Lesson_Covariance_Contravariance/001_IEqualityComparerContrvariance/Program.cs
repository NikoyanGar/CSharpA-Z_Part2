namespace _001_IEqualityComparerContrvariance;

internal class Program
{
    static void Main(string[] args)
    {
        IEqualityComparer<Dog> equalityComparer = new AnimalEqualityComparer();
        var dogSet = new HashSet<Dog>(equalityComparer);

        dogSet.Add(new Dog { Name = "Rex" });
        dogSet.Add(new Dog { Name = "Rex" }); // будет проигнорирован, так как сравнение по Name
        Console.WriteLine("Hello, World!");
    }
}

//хотя HashSet<Dog> требует IEqualityComparer<Dog>, мы спокойно передали IEqualityComparer<Animal>.
class Animal
{
    public string Name { get; set; }
}
class Dog : Animal { }

class AnimalEqualityComparer : IEqualityComparer<Animal>
{
    public bool Equals(Animal x, Animal y) => x.Name == y.Name;
    public int GetHashCode(Animal obj) => obj.Name.GetHashCode();
}
//Повторное использование кода
//Один компаратор или равнитель для Animal может работать и с Dog, и с Cat.

//Гибкость
//Когда мы пишем обобщённый код (например, коллекции, сортировка, поиск), не нужно писать 10 разных компараторов.

//Dependency Injection
//В DI-контейнер можно зарегистрировать IComparer<Animal>, а потом использовать его даже там, где нужен IComparer<Dog>.
