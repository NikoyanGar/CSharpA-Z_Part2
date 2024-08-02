namespace _004_Generics
{
    //Generic Methods
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Yerevan");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            // Printer printer = new Printer();
            // printer.Print<int>(100);
            // printer.Print(200); // type infer from the specified value
        }
    }
    class DataStore<T>
    {
        private T[] _data = new T[10];
        //A method declared with the type parameters for its return type or parameters is called a generic method.
        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T? GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default;
        }
        #region Generic Method Overloading
        public void AddOrUpdate(T data1, T data2) { }
        public void AddOrUpdate<U>(T data1, U data2) { }
        public void AddOrUpdate(T data) { }
        #endregion
    }
    //Generic Method in Non-generic Class
    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
}
