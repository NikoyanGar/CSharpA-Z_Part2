using System.Collections;

namespace _007_Generics
{
    //C# Generic Constraints
    internal class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> store = new DataStore<string>(); // valid
            DataStore<MyClass> store1 = new DataStore<MyClass>(); // valid
            DataStore<IMyInterface> store2 = new DataStore<IMyInterface>(); // valid
            DataStore<IEnumerable> store3 = new DataStore<IEnumerable>(); // valid
            //DataStore<IEnumerable> store3 = new DataStore<IMyInterface>(); // valid
            DataStore<ArrayList> store4 = new DataStore<ArrayList>(); // valid
            //DataStore<int> store = new DataStore<int>(); // compile-time error 
            ;
        }
    }
    //GenericTypeName<T> where T  : contraint1, constraint2
    class DataStore<T> where T : class //which means only a reference type can be passed as an argument
    {
        public T Data { get; set; }
    }

    //class	The type argument must be any class, interface, delegate, or array type.
    //class? The type argument must be a nullable or non-nullable class, interface, delegate, or array type.
    //struct The type argument must be non-nullable value types such as primitive data types int, char, bool, float, etc.
    //new () The type argument must be a reference type which has a public parameterless constructor.It cannot be combined with struct and unmanaged constraints.
    //notnull Available C# 8.0 onwards. The type argument can be non-nullable reference types or value types. If not, then the compiler generates a warning instead of an error.
    //unmanaged The type argument must be non-nullable unmanged types.
    //base class name The type argument must be or derive from the specified base class. The Object, Array, ValueType classes are disallowed as a base class constraint. The Enum, Delegate, MulticastDelegate are disallowed as base class constraint before C# 7.3.
    //<base class name>? The type argument must be or derive from the specified nullable or non-nullable base class
    //<interface name>	The type argument must be or implement the specified interface.
    //<interface name>? The type argument must be or implement the specified interface. It may be a nullable reference type, a non-nullable reference type, or a value type
    //where T: U The type argument supplied for T must be or derive from the argument supplied for U.
}
