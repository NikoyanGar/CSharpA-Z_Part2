namespace Covariance_simple
{
    // Ковариантность
    // Ключевое слово out: Ковариантные типы параметров должны быть объявлены с использованием
    // ключевого слова out.
    // Использование в возвращаемых значениях: Ковариантные типы могут использоваться только
    // в возвращаемых значениях методов интерфейса.
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCatsCollection originalCatCollection = new MyCatsCollection();
            originalCatCollection.Add(new Cat() { Id = 1, Name = "cat0" });
            originalCatCollection.Add(new Cat() { Id = 2, Name = "cat1" });
            originalCatCollection.Add(new Cat() { Id = 3, Name = "cat2" });

            MyDogsCollection originalDogCollection = new MyDogsCollection();
            originalDogCollection.Add(new Dog() { Id = 4, Name = "dog0" });
            originalDogCollection.Add(new Dog() { Id = 5, Name = "dog1" });
            originalDogCollection.Add(new Dog() { Id = 6, Name = "dog2" });

            ICovariantCollection<Cat> covariantWithSameType = originalCatCollection;
            Cat cat1 = covariantWithSameType.Get(0);
            ICovariantCollection<Animal> covariantWithBaseType = originalCatCollection;
            ICovariantCollection<Animal> covariantDogWithBaseType = originalDogCollection;
            Animal animal = covariantWithBaseType.Get(0);

            List<Animal> animals = new List<Animal>();
            Console.WriteLine("cats");
            foreach (var item in originalCatCollection.GetAll())
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("dogs");

            foreach (var item in originalDogCollection.GetAll())
            {
                Console.WriteLine(item.Name);
            }
            //Or
            Console.WriteLine("Animals");
            animals.AddRange(covariantWithBaseType.GetAll());
            animals.AddRange(covariantDogWithBaseType.GetAll());
            foreach (var item in animals)
            {
                Console.WriteLine(item.Name);
            }

            //order animals by comparing with MyAnimalsContrvariantComparer
            animals.Sort(new MyObjectContrvariantComparer());
            Console.WriteLine("Sorted Animals");
            foreach (var item in animals)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
    public interface ICovariantCollection<out T>
    {
        T Get(int index);
        IEnumerable<T> GetAll();
    }

    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Cat : Animal { }

    public class Dog : Animal { }

    public class MyCatsCollection : ICovariantCollection<Cat>
    {
        private readonly List<Cat> items = new List<Cat>();
        public Cat Get(int index)
        {
            return items[index];
        }

        public void Add(Cat item)
        {
            items.Add(item);
        }

        public IEnumerable<Cat> GetAll()
        {
            return items;
        }
    }
    public class MyDogsCollection : ICovariantCollection<Dog>
    {
        private readonly List<Dog> items = new List<Dog>();
        public Dog Get(int index)
        {
            return items[index];
        }

        public void Add(Dog item)
        {
            items.Add(item);
        }

        public IEnumerable<Dog> GetAll()
        {
            return items;
        }
    }

    public class MyObjectContrvariantComparer : IComparer<object>
    {
        public int Compare(object? x, object? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            else if (x == null)
            {
                return -1;
            }
            else if (y == null)
            {
                return 1;
            }
            else
            {
                return x.GetHashCode().CompareTo(y);
            }
        }
    }
    public class MyAnimalsContrvariantComparer : IComparer<Animal>
    {
        public int Compare(Animal? x, Animal? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            else if (x == null)
            {
                return -1;
            }
            else if (y == null)
            {
                return 1;
            }
            else
            {
                return x.Id.CompareTo(y.Id);
            }
        }
    }
    public class MyCatsContrvariantComparer : IComparer<Cat>
    {
        public int Compare(Cat? x, Cat? y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            else if (x == null)
            {
                return -1;
            }
            else if (y == null)
            {
                return 1;
            }
            else
            {
                return x.Id.CompareTo(y.Id);
            }
        }
    }


}
