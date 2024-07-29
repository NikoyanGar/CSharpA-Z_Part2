namespace _004_Interface_vs_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IPoint
    {
        int X { get; set; }
        int Y { get; set; }

        public abstract static IPoint operator +(IPoint left, IPoint right);

        public abstract static IPoint operator -(IPoint left, IPoint right);
    }
}
