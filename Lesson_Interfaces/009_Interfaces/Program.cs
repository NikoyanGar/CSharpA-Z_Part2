namespace _009_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstration of different cases
            IService service1 = new S1();
            IService service2 = new S2();

            // First Case: ServiceOne
            Console.WriteLine("First Case:");
            service1.Add();
            service1.Mul();

            Console.WriteLine("------------------------------------");

            // Second Case: ServiceTwo
            Console.WriteLine("Second Case:");
            service2.Add();
            service2.Mul();
        }
    }
    public interface IService
    {
        void Add();
        void Mul();
    }
    // First Case
    public abstract class ServiceOne : IService
    {
        public abstract void Add();
        public abstract void Mul();
    }
    // Second Case
    public abstract class ServiceTwo : IService
    {
        public void Add()
        {
            Console.WriteLine("ServiceTwo Add");
        }
        public void Mul()
        {
            Console.WriteLine("ServiceTwo Mul");
        }
    }

    public class S1 : ServiceOne
    {
        public override void Add()
        {
            Console.WriteLine("S1 Add");
        }
        public override void Mul()
        {
            Console.WriteLine("S1 Mul");
        }
    }
    public class S2 : ServiceTwo
    { }
}
