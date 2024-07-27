namespace _003_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPoint p = new Point(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);
        }
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        }
    }
    interface IPoint
    {
        // Property signatures:
        int X { get; set; }

        int Y { get; set; }

        double Distance { get; }
    }

    class Point : IPoint
    {
        // Constructor:
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Property implementation:
        public int X { get; set; }

        public int Y { get; set; }

        // Property implementation
        public double Distance =>
           Math.Sqrt(X * X + Y * Y);
    }
}
