namespace _008_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass concreteClass = new ConcreteClass();
            Interface @interface = concreteClass;
            AbstractClass abstractClass = concreteClass;

        }
    }

    // Abstract class
    abstract class AbstractClass
    {

        // Method declaration in abstract class
        public abstract void AbstractMethod();
    }

    // Interface
    interface Interface
    {

        // Method declaration in interface
        void InterfaceMethod();
    }

    // Here, GFg class inherit abstract class and interface
    class ConcreteClass : AbstractClass, Interface
    {

        // Method definition for abstract method
        public override void AbstractMethod()
        {
            Console.WriteLine("I am the method of abstract class");
        }

        // Method definition for interface
        public void InterfaceMethod()
        {
            Console.WriteLine("I am the method of interface");
        }
    }
}
