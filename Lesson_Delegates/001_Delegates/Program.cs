namespace _001_Delegates
{
    //A delegate is a named type that defines a particular kind of method.
    //Just as a class definition lays out all the members for the given kind of object it defines,
    //the delegate lays out the method signature for the kind of method it defines.
    internal class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass { Id = 1003 };
            // Create a delegate instance called myAction and assign it the Method1 method of the myClass object
            var myAction = new MyAction(myClass.Method1);
            // Create another delegate instance called myAction1 and assign it the Method2 method of the myClass object
            var myAction1 = new MyAction(myClass.Method2);
            // Invoke the Method2 method through the myAction1 delegate
            myAction1.Invoke();
            // Invoke the Method1 method through the myAction delegate
            myAction();

            var my2 = new MyClass { Id = -10 };
            // Invoke the Method1 method through the myAction delegate using reflection
            myAction.Method.Invoke(myAction.Target, null);

            // Read a line of input from the console
            Console.ReadLine();
        }

        // Define a delegate type called MyAction that represents a method with no parameters and no return value
        private delegate void MyAction();
    }

    public class MyClass
    {
        public int Id { get; set; }

        public void Method1()
        {
            Console.WriteLine("Call Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Call Method2");
        }
    }
}
