namespace _003_ValueVsReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point { X = 10, Y = 20 };
            Point p2 = new Point { X = 10, Y = 20 };
            Point p3 = new Point { X = 5, Y = 15 };

            bool isEqual1 = p1.Equals(p2); // true
            bool isEqual2 = p1.Equals(p3); // false

            //bool isEquals3 = p1 == p2; // false

        }
        public struct Point
        {
            public int X;
            public int Y;
        }
    }
}
