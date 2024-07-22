namespace _002_Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    abstract class Shape //comment abstract
    {
        public abstract double CalculateArea();//comment abstract
        public double CalculatePerimeter()
        {
            return 0;
        }
        //As a general rule, a method that is declared as abstract has no "body"
        //and can only be declared inside the abstract class.

        public string Name { get; set; }
        public int _age;
    }
}
