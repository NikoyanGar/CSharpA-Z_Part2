namespace MyLibrary
{
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/default-interface-methods
    public interface IMyInterface
    {
        void Method1();
        void Method2();

        // Default method added in a newer version of the interface
        // Provides a default implementation for Method3
        // Ensures backward compatibility with code written for older versions of the interface
        // Newer implementations of the interface can override this default implementation
        // Older implementations of the interface will automatically use this default implementation
        // without needing to modify their code
        public void Method3()
        {
            Console.WriteLine("Default implementation of Method3");
        }
    }

    public class MyClass : IMyInterface
    {
        public void Method1()
        {
            Console.WriteLine("Method1 implementation");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 implementation");
        }
    }
    public class MyClass1 : IMyInterface
    {
        public void Method1()
        {
            Console.WriteLine("Method1 implementation");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 implementation");
        }
        public void Method3()
        {
            Console.WriteLine("custom implementation of Method3");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMyInterface myObject = new MyClass();
            myObject.Method1();
            myObject.Method2();
            myObject.Method3(); // Calls the default implementation of Method3

            //var myClass = new MyClass1();
            //IMyInterface myInterface = myClass;
            //myInterface.Method3();

            Console.ReadLine();
        }
    }
}
