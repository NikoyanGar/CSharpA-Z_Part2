namespace _001_Partial_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public partial class Employee//make private 
    {
        public void DoWork()
        {
        }
    }

    public partial class Employee
    {
        public void GoToLunch()
        {
        }
    }
}
