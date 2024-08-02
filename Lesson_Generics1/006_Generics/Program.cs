namespace _006_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstration of performance advantage of generics
            // without boxing and unboxing

            // Using a non-generic list
            NonGenericList nonGenericList = new NonGenericList();
            nonGenericList.Add(10);
            nonGenericList.Add(20);
            nonGenericList.Add(30);
            //nonGenericList.Add("hi");

            int sum1 = nonGenericList.Sum(); // Boxing and unboxing occurs here

            // Using a generic list
            GenericList<int> genericList = new GenericList<int>();
            genericList.Add(10);
            genericList.Add(20);
            genericList.Add(30);

            int sum2 = genericList.Sum(); // No boxing and unboxing occurs here

            Console.WriteLine($"Sum using non-generic list: {sum1}");
            Console.WriteLine($"Sum using generic list: {sum2}");
        }
    }

    // Non-generic list implementation
    public class NonGenericList
    {
        private System.Collections.ArrayList list = new System.Collections.ArrayList();

        public void Add(object item)
        {
            list.Add(item);
        }

        public int Sum()
        {
            int sum = 0;
            foreach (object item in list)
            {
                sum += (int)item; // Boxing and unboxing occurs here
            }
            return sum;
        }
    }

    // Generic list implementation
    public class GenericList<T>
    {
        private System.Collections.Generic.List<T> list = new System.Collections.Generic.List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public T Sum()
        {
            T sum = default(T);
            foreach (T item in list)
            {
                sum += (dynamic)item; // No boxing and unboxing occurs here
            }
            return sum;
        }
    }
}
