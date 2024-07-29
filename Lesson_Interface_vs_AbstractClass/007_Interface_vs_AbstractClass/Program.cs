using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace _006_Interface_vs_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the class implementing the interface
            IInterfaceExample interfaceExample = new InterfaceExample();

            // Create an instance of the class inheriting from the abstract class
            AbstractClassExample abstractClassExample = new ConcreteClassExample();

            // Run the benchmark for the interface
            BenchmarkRunner.Run<InterfaceBenchmark>();

            // Run the benchmark for the abstract class
            BenchmarkRunner.Run<AbstractClassBenchmark>();
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

    public class InterfaceBenchmark
    {
        private IInterfaceExample _interfaceExample;

        [GlobalSetup]
        public void Setup()
        {
            _interfaceExample = new InterfaceExample();
        }

        [Benchmark]
        public void InterfaceMethodBenchmark()
        {
            _interfaceExample.Method();
        }
    }

    public class AbstractClassBenchmark
    {
        private AbstractClassExample _abstractClassExample;

        [GlobalSetup]
        public void Setup()
        {
            _abstractClassExample = new ConcreteClassExample();
        }

        [Benchmark]
        public void AbstractClassMethodBenchmark()
        {
            _abstractClassExample.Method();
        }
    }
}