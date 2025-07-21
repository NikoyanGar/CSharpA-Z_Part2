using System.Xml;

namespace MaxOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public static int Max(int a, int b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
        public static double Max(double a, double b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
        public static Human Max(Human a, Human b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        #region solution
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
        #endregion
    }
}
