using System.Diagnostics;

namespace _006_Interface_vs_AbstractClass
{
    //The performance of interface is slow because it requires time to search actual method in the corresponding class
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the class implementing the interface
            IInterfaceExample interfaceExample = new InterfaceExample();

            // Create an instance of the class inheriting from the abstract class
            AbstractClassExample abstractClassExample = new ConcreteClassExample();

            // Run the benchmark for the interface
            BenchmarkInterface(interfaceExample);

            // Run the benchmark for the abstract class
            BenchmarkAbstractClass(abstractClassExample);
        }

        static void BenchmarkInterface(IInterfaceExample interfaceExample)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Call the method from the interface multiple times
            for (int i = 0; i < 100000000; i++)
            {
                interfaceExample.Method();
            }

            stopwatch.Stop();
            Console.WriteLine($"Interface benchmark: {stopwatch.ElapsedMilliseconds} ms");
        }

        static void BenchmarkAbstractClass(AbstractClassExample abstractClassExample)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Call the method from the abstract class multiple times
            for (int i = 0; i < 100000000; i++)
            {
                abstractClassExample.Method();
            }

            stopwatch.Stop();
            Console.WriteLine($"Abstract class benchmark: {stopwatch.ElapsedMilliseconds} ms");
        }
    }

    interface IInterfaceExample
    {
        void Method();
    }

    class InterfaceExample : IInterfaceExample
    {
        public void Method()
        {
            // Implementation of the method
        }
    }

    abstract class AbstractClassExample
    {
        public abstract void Method();
    }

    class ConcreteClassExample : AbstractClassExample
    {
        public override void Method()
        {
            // Implementation of the method
        }
    }
}
