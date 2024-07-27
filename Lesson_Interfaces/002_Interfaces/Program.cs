namespace _002_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ImplementationClass implementationClass = new ImplementationClass();
            //implementationClass.SampleMethod();
            ISampleInterface sampleInterface = implementationClass;
            sampleInterface.SampleMethod();

            ImplementationClass1 implementationClass1 = new ImplementationClass1();
            implementationClass1.SampleMethod();
            ISampleInterface sampleInterface1 = implementationClass;
            sampleInterface1.SampleMethod();

        }
    }
    interface ISampleInterface
    {
        void SampleMethod();
    }

    class ImplementationClass : ISampleInterface
    {
        // Explicit interface member implementation:
        // This means that the method is only accessible through an instance of the interface.
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("ImplementationClass");
        }
    }
    class ImplementationClass1 : ISampleInterface
    {
        //implemented normally without any explicit interface implementation
        public void SampleMethod()
        {
            Console.WriteLine("ImplementationClass1");
        }
    }
}
