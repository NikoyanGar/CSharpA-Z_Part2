namespace _002_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance = new MyClass();

            MyAction myAction = new MyAction(instance.Method); // Create a delegate instance called myAction and assign it the Method from the instance of MyClass

            WriteDelInfo(myAction); // Call the WriteDelInfo method and pass the myAction delegate as an argument

            Console.ReadLine();
        }

        public static void WriteDelInfo(MyAction ma)
        {
            string text = ma.Invoke("AAA"); // Invoke the delegate myAction with the argument "AAA" and assign the returned value to the text variable
            Console.WriteLine(text); // Print the value of the text variable to the console
        }

        public delegate string MyAction(string name); // Define a delegate type called MyAction that takes a string argument and returns a string
    }

    public class MyClass
    {
        public string Method(string name)
        {
            return "Hello " + name;
        }
    }
}
