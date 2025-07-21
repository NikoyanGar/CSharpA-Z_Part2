namespace TryConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TryConvert Demonstrations ===");
            TryConvertExamples.Run();

            Console.WriteLine("\n=== Non-Generic Conversion Demonstrations ===");
            NonGenericConversionExamples.Run();

            Console.WriteLine("\n=== Generic Conversion Demonstrations ===");
            GenericConversionExamples.Run();
        }
    }

    // Demonstrates TryConvert usage
    public static class TryConvertExamples
    {
        public static void Run()
        {
            if (TryConvertUtil.TryConvert("123", out int intResult))
                Console.WriteLine($"Converted '123' to int: {intResult}");
            else
                Console.WriteLine("Failed to convert '123' to int.");

            if (TryConvertUtil.TryConvert("abc", out int failInt))
                Console.WriteLine($"Converted 'abc' to int: {failInt}");
            else
                Console.WriteLine("Failed to convert 'abc' to int.");

            if (TryConvertUtil.TryConvert(42.5, out int roundedInt))
                Console.WriteLine($"Converted 42.5 to int: {roundedInt}");

            if (TryConvertUtil.TryConvert(100, out string strFromInt))
                Console.WriteLine($"Converted 100 to string: {strFromInt}");
        }
    }

    // Demonstrates non-generic conversion helpers
    public static class NonGenericConversionExamples
    {
        public static void Run()
        {
            int intValue = TryConvertUtil.ConvertToInt("456");
            Console.WriteLine($"ConvertToInt: {intValue}");

            double doubleValue = TryConvertUtil.ConvertToDouble("3.14");
            Console.WriteLine($"ConvertToDouble: {doubleValue}");

            string strValue = TryConvertUtil.ConvertToString(789);
            Console.WriteLine($"ConvertToString: {strValue}");
        }
    }

    // Demonstrates generic conversion helpers and their advantages
    public static class GenericConversionExamples
    {
        public static void Run()
        {
            // 1. Type safety: Compile-time checking prevents invalid casts
            int intValue = TryConvertUtil.GenericConvert<string, int>("123");
            Console.WriteLine($"GenericConvert<string, int>: {intValue}");

            // 2. No boxing/unboxing for value types
            double doubleValue = TryConvertUtil.GenericConvert<int, double>(42);
            Console.WriteLine($"GenericConvert<int, double>: {doubleValue}");

            // 3. Reusability: Works for any convertible types
            string strValue = TryConvertUtil.GenericConvert<int, string>(789);
            Console.WriteLine($"GenericConvert<int, string>: {strValue}");

            // 4. Cleaner code: No need for multiple overloads or type checks
            if (TryConvertUtil.GenericTryConvert("456.78", out double parsedDouble))
                Console.WriteLine($"GenericTryConvert<string, double>: {parsedDouble}");
            else
                Console.WriteLine("Failed to convert string to double.");

            // 5. Consistency: Same method signature for all conversions
            if (TryConvertUtil.GenericTryConvert("notanint", out int failInt))
                Console.WriteLine($"GenericTryConvert<string, int>: {failInt}");
            else
                Console.WriteLine("Failed to convert string to int.");
        }
    }

    // Utility class for conversion logic
    public static class TryConvertUtil
    {
        // Generic TryConvert
        public static bool TryConvert<TFrom, TTo>(TFrom value, out TTo result)
        {
            try
            {
                result = (TTo)Convert.ChangeType(value, typeof(TTo));
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }

        // Non-generic overloads for demonstration
        public static int ConvertToInt(object value)
        {
            if (TryConvert(value, out int result))
                return result;
            throw new InvalidCastException($"Cannot convert {value} to int.");
        }

        public static double ConvertToDouble(object value)
        {
            if (TryConvert(value, out double result))
                return result;
            throw new InvalidCastException($"Cannot convert {value} to double.");
        }

        public static string ConvertToString(object value)
        {
            if (TryConvert(value, out string result))
                return result;
            throw new InvalidCastException($"Cannot convert {value} to string.");
        }

        // Generic conversion method
        public static TTo GenericConvert<TFrom, TTo>(TFrom value)
        {
            if (GenericTryConvert(value, out TTo result))
                return result;
            throw new InvalidCastException($"Cannot convert {value} from {typeof(TFrom)} to {typeof(TTo)}.");
        }

        // Generic TryConvert method
        public static bool GenericTryConvert<TFrom, TTo>(TFrom value, out TTo result)
        {
            try
            {
                result = (TTo)Convert.ChangeType(value, typeof(TTo));
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }
    }
}

