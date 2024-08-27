namespace _003_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance = new MyClass();

            // Create instances of the MyAction delegate and assign them to different methods of the MyClass instance
            var myAction1 = new MyAction(instance.Method1);
            var myAction2 = new MyAction(instance.Method2);
            var myAction3 = new MyAction(instance.Method3);

            // Uncomment the following line to invoke Method1 using myAction1 delegate
            // myAction1();

            // Uncomment one of the following lines to create a delegate chain using the + operator

            MyAction myAction = myAction2 + myAction2 + myAction3;

            // Invoke the delegate chain using the Invoke() method
            myAction.Invoke();

            // Remove myAction3 from the delegate chain using the -= operator
            myAction -= myAction3;

            // Invoke the modified delegate chain
            myAction.Invoke();

            // Uncomment the following line to invoke the delegate chain using the shorthand syntax
            // myAction();

            Console.ReadLine();
        }

        public delegate void MyAction();
    }
    public class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Call Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Call Method2");
        }

        public void Method3()
        {
            Console.WriteLine("Call Method3");
        }

        public string Method4<T>(T a)
        {
            return a.ToString();
        }
    }
}
