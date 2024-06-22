namespace _004_ValueVsReference
{
    internal class Program
    {
        //memberwise comparison
        static void Main(string[] args)
        {
            Point p1 = new Point { X = 10, Y = 20 };
            Point p2 = new Point { X = 10, Y = 20 };
            Point p3 = new Point { X = 5, Y = 15 };

            bool isEqual1 = p1.Equals(p2); // true
            bool isEqual2 = p1.Equals(p3); // false

            bool isEquals3 = p1 == p2; // false

        }
        public struct Point
        {
            public int X;
            public int Y;

            public static bool operator ==(Point p1, Point p2)
            {
                return p1.X == p2.X && p1.Y == p2.Y;
            }

            public static bool operator !=(Point p1, Point p2)
            {
                return !(p1 == p2);
                // return p1.X != p2.X || p1.Y != p2.Y;
            }

            //public override bool Equals(object obj)
            //{
            //    throw new NotImplementedException();
            //}

            //public override int GetHashCode()
            //{
            //    throw new NotImplementedException();
            //}
        }
    }
}
