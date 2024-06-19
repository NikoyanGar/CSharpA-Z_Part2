namespace _006_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example of using named parameters
            PrintPersonDetails(name: "John", age: 25, city: "New York");
            PrintPersonDetails(age: 25, name: "John", city: "New York");
        }

        static void PrintPersonDetails(string name, int age, string city)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"City: {city}");
        }
    }
}
