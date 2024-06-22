namespace _009_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Call the method with the optional parameter
            MyMethod("Hello");
            MyMethod();
            MyMethod2(5);
            MyMethod2();

        }

        static void MyMethod(string message = "Default message")
        {
            Console.WriteLine(message);
        }
        static void MyMethod2(int number = 0)
        {
            Console.WriteLine(number);
        }
        static void MyMethod2(int number, int number1 = 0)
        {
            Console.WriteLine(number);
        }
        //static void MyMethod2(int number = 1, int number1)
        //{
        //    Console.WriteLine(number);
        //}
        //static void MyMethod2(int number = 1, int number1 = 0)
        //{
        //    Console.WriteLine(number);
        //}
        //static void MyMethod(int number = 0)//uncomment this method and comment the above method to see the error
        //{
        //    Console.WriteLine(number);
        //}
    }
}
