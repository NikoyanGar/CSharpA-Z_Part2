namespace _001_Interface_vs_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public interface IInterFace
    {
        //public IInterFace() cannot contain ctor
        //{

        //}
    }
    public abstract class AbstractClass
    {
        public AbstractClass()
        {

        }
        public AbstractClass(int i)
        {

        }
    }

}
