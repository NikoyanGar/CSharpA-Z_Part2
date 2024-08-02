namespace _001_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiating Generic Class
            //compiler will create a class with the type parameter replaced by the specified type( string, int , object)
            DataStore<string> store = new DataStore<string>();
            store.Data = "Hello World!";
            //store.Data = 123; //compile-time error
            DataStore<int> store1 = new DataStore<int>();
            DataStore<object> store2 = new DataStore<object>();
            Console.WriteLine(store.Data);


            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";
        }
    }
    //Generic classes are defined using a type parameter in an angle brackets after the class name. The following defines a generic class.
    class DataStore<T>
    {
        public T Data { get; set; }//T is called type parameter, which can be used as a type of fields, properties, method parameters, return types
    }
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}
