namespace _002_Interface_vs_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class MyClass : MyAbstractClass, /*MyAbstractClass1*/ MyInterface1, MyInterface2, MyInterface3// :MyAbstractClass
    {

    }
    public interface MyInterface1
    {

    }
    public interface MyInterface2
    {

    }
    public interface MyInterface3
    {

    }
    public abstract class MyAbstractClass
    {

    }
    public abstract class MyAbstractClass1
    {

    }
}
