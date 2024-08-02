namespace _005_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstration of the advantages of generics
            // Reusability of code without handling different data types

            // Example 1: Generic method
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };

            Console.WriteLine("Sum of intArray: " + SumArray(intArray));
            Console.WriteLine("Sum of doubleArray: " + SumArray(doubleArray));

            // Example 2: Generic class
            MyGenericClass<int> intObj = new MyGenericClass<int>(10);
            MyGenericClass<string> stringObj = new MyGenericClass<string>("Hello, World!");

            Console.WriteLine("Value of intObj: " + intObj.GetValue());
            Console.WriteLine("Value of stringObj: " + stringObj.GetValue());

            // Example 3: Generic method to swap elements
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Before swapping: " + string.Join(", ", numbers));
            SwapElements(numbers, 1, 3);
            Console.WriteLine("After swapping: " + string.Join(", ", numbers));
        }

        // Generic method to swap elements in an array
        static void SwapElements<T>(T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        // Generic method to calculate the sum of an array
        static T SumArray<T>(T[] array)
        {
            dynamic sum = default(T);
            foreach (T item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        // Generic class
        class MyGenericClass<T>
        {
            private T value;

            public MyGenericClass(T value)
            {
                this.value = value;
            }

            public T GetValue()
            {
                return value;
            }
        }
    }
}
