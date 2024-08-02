namespace _002_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Demonstrate generic class characteristics
            // Create an instance of a generic class with int as the type parameter
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>();
            intGenericClass.Add(10);
            intGenericClass.Add(20);
            intGenericClass.Display();

            // Create an instance of a generic class with string as the type parameter
            MyGenericClass<string> stringGenericClass = new MyGenericClass<string>();
            stringGenericClass.Add("Hello");
            stringGenericClass.Add("World");
            stringGenericClass.Display();
        }
    }

    // Generic class definition
    //A generic class increases the reusability. The more type parameters mean more reusable it becomes.
    //However, too much generalization makes code difficult to understand and maintain.
    public class MyGenericClass<T>
    {
        private List<T> items;

        public MyGenericClass()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Display()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
