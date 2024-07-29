namespace _008_Interface_vs_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    internal interface IPeripheralAbility
    {
        void PerformAbility();
    }

    internal abstract class CoreIdentity
    {
        public abstract string GetIdentity();
    }

    internal class Human : CoreIdentity, IPeripheralAbility
    {
        public void PerformAbility()
        {
            Console.WriteLine("Human is performing an ability.");
        }

        public override string GetIdentity()
        {
            return "I am a human.";
        }
    }
}
