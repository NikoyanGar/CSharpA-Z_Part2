namespace _003_Generics
{
    //A generic class can be a base class to other generic or non-generic classes or abstract classes.
    //A generic class can be derived from other generic or non-generic interfaces, classes, or abstract classes.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //BaseClass<int> baseClass = new BaseClass<int>();    
            // Example of using a generic class as a base class
            DerivedClass<int> derivedClass = new DerivedClass<int>();
            BaseClass<int> baseClass = derivedClass;
            derivedClass.PrintValue(10);
        }
    }

    // Generic base class
    public class BaseClass<T>
    {
        public void PrintValue(T value)
        {
            Console.WriteLine("Value: " + value);
        }
    }

    // Derived class inheriting from the generic base class
    public class DerivedClass<T> : BaseClass<T>
    {
        // Additional members and functionality can be added here
    }
}
