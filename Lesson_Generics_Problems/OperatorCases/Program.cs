namespace OperatorCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Example usages for all solutions:

            // 1. Overloaded Add methods
            int sumInt = Add(2, 3);
            double sumDouble = Add(2.5, 3.1);
            byte sumByte = Add((byte)1, (byte)2);

            Console.WriteLine($"Add(int): {sumInt}");
            Console.WriteLine($"Add(double): {sumDouble}");
            Console.WriteLine($"Add(byte): {sumByte}");

            // 2. Using dynamic
            var sumDyn = Add_Dynamic(10, 20);
            var sumDynDouble = Add_Dynamic(1.5, 2.5);
            Console.WriteLine($"Add_Dynamic(int): {sumDyn}");
            Console.WriteLine($"Add_Dynamic(double): {sumDynDouble}");

            // 3. Using generic math (C# 11+, .NET 7+)
            var sumGenMath = Add_GenericMath(100, 200);
            var sumGenMathDecimal = Add_GenericMath(1.1m, 2.2m);
            Console.WriteLine($"Add_GenericMath(int): {sumGenMath}");
            Console.WriteLine($"Add_GenericMath(decimal): {sumGenMathDecimal}");

            // 4. Using expression trees
            var sumExpr = Add_Expression(7, 8);
            var sumExprFloat = Add_Expression(1.2f, 3.4f);
            Console.WriteLine($"Add_Expression(int): {sumExpr}");
            Console.WriteLine($"Add_Expression(float): {sumExprFloat}");

            // 5. Custom type with operator+
            var myNum1 = new MyNumber(5);
            var myNum2 = new MyNumber(10);
            var myNumSum = myNum1 + myNum2;
            Console.WriteLine($"MyNumber + MyNumber: {myNumSum.Value}");
        }

        #region Problem: Add Methods for All Numeric Types

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static long Add(long a, long b)
        {
            return a + b;
        }

        public static float Add(float a, float b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static short Add(short a, short b)
        {
            return (short)(a + b);
        }

        public static ushort Add(ushort a, ushort b)
        {
            return (ushort)(a + b);
        }

        public static byte Add(byte a, byte b)
        {
            return (byte)(a + b);
        }

        public static sbyte Add(sbyte a, sbyte b)
        {
            return (sbyte)(a + b);
        }

        public static uint Add(uint a, uint b)
        {
            return a + b;
        }

        public static ulong Add(ulong a, ulong b)
        {
            return a + b;
        }

        #endregion

        #region solutions

        // Solution 1: Using dynamic (already present)
        public static T Add_Dynamic<T>(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

        // Solution 2: Using generic math (C# 11+, .NET 7+)
        public static T Add_GenericMath<T>(T a, T b) where T : System.Numerics.INumber<T>
        {
            return a + b;
        }

        // Solution 3: Using Expression Trees (works for numeric types, slower, compile-time caching recommended)
        private static class AddExpressionCache<T>
        {
            public static readonly Func<T, T, T> AddFunc = CreateAddFunc();

            private static Func<T, T, T> CreateAddFunc()
            {
                var paramA = System.Linq.Expressions.Expression.Parameter(typeof(T), "a");
                var paramB = System.Linq.Expressions.Expression.Parameter(typeof(T), "b");
                var body = System.Linq.Expressions.Expression.Add(paramA, paramB);
                return System.Linq.Expressions.Expression.Lambda<Func<T, T, T>>(body, paramA, paramB).Compile();
            }
        }

        public static T Add_Expression<T>(T a, T b)
        {
            return AddExpressionCache<T>.AddFunc(a, b);
        }

        // Solution 4: Using operator overloading for custom types (example for completeness)
        // This is not a generic solution, but shows how to implement operator+ for a custom type.
        public struct MyNumber
        {
            public int Value;
            public MyNumber(int value) => Value = value;
            public static MyNumber operator +(MyNumber a, MyNumber b) => new MyNumber(a.Value + b.Value);
        }

        #endregion
    }
}
