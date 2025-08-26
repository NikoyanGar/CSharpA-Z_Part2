namespace _001_IEnumerableCovariance;
//Итого:
//Ковариантность позволяет воспринимать коллекции «потомков» как коллекции «базового типа».
//Это работает там, где коллекция только отдаёт значения, а не принимает.
//Типичный пример — IEnumerable<out T>.
internal class Program
{
    static void Main(string[] args)
    {
        IEnumerable<Dog> dogs = new List<Dog> { new Dog(), new Dog() };
        IEnumerable<Cat> cats = new List<Cat> { new Cat(), new Cat() };

        //❓ Можем ли мы эти коллекции «склеить» в одну коллекцию животных?

        IEnumerable<Animal> animals = dogs; // ✅ работает
        animals = cats; // ✅ работает

        foreach (var animal in animals)
        {
            animal.Speak(); // вызовет Dog или Cat звук
        }

        PrintAnimals(dogs); // можно передать IEnumerable<Dog>
        PrintAnimals(cats); // можно передать IEnumerable<Cat>
    }
    static void PrintAnimals(IEnumerable<Animal> animals)
    {
        foreach (var a in animals)
            a.Speak();
    }
    //⚠ В IEnumerable<T> нельзя добавлять элементы (например, animals.Add(new Cat())) — только читать.
    //Именно поэтому T можно сделать ковариантным: он используется только в выходе (out).
}
class Animal
{
    public virtual void Speak() => Console.WriteLine("Some animal sound");
}

class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Woof!");
}

class Cat : Animal
{
    public override void Speak() => Console.WriteLine("Meow!");
}
