using System;

namespace _005_Interface_vs_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Example demonstrating access modifiers in abstract class
            AbstractClassExample? abstractClassExample = default;
            abstractClassExample?.PublicMethod(); // Accessible
            //abstractClassExample.ProtectedMethod(); // Accessible
            // abstractClassExample.PrivateMethod(); // Not accessible

            // Example demonstrating access modifiers in interface
            InterfaceExample? interfaceExample = default;
            interfaceExample?.PublicMethod(); // Accessible
            // interfaceExample.ProtectedMethod(); // Not accessible
            // interfaceExample.PrivateMethod(); // Not accessible
        }
    }

    public abstract class AbstractClassExample
    {
        public void PublicMethod()
        {
            Console.WriteLine("Public method in abstract class");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method in abstract class");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private method in abstract class");
        }
    }

    public interface InterfaceExample
    {
        public void PublicMethod();// access modifiers by 8 version

        protected void ProtectedMethod();

        private void PrivateMethod()
        {
            Console.WriteLine("Private method in abstract class");
        }
    }
}
