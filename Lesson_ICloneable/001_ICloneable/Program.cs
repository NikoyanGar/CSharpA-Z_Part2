namespace _001_ICloneable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human originalHuman = new Human();
            originalHuman.Name = "John";
            originalHuman.Age = 30;

            Human clonedHuman = new Human();
            clonedHuman.Name = originalHuman.Name;
            clonedHuman.Age = originalHuman.Age;
        }
    }

    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
