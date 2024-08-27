namespace _004_Delegates
{
    internal class Program
    {
        // Define a delegate named MyAction that represents a method with no parameters and no return value
        public delegate void MyAction();

        // Declare a static variable of type MyAction named myAction
        public static MyAction myAction;

        static void Main(string[] args)
        {
            // Uncomment the following lines to create an instance of MyAction using an anonymous method
            // MyAction myAction = new MyAction(delegate 
            // {
            //     Console.WriteLine("Hello Delegate!!!");
            // });

            // Assign an anonymous method to the myAction delegate using the delegate keyword
            myAction = delegate { Console.WriteLine("Hello Delegate!!!"); };

            // Call the CallDel method, which will invoke the myAction delegate
            CallDel();

            // Uncomment the following lines to directly invoke the myAction delegate
            // myAction.Invoke();
            // myAction.Invoke();

            // Read a line from the console to prevent the program from closing immediately
            Console.ReadLine();
        }

        // Define the CallDel method, which invokes the myAction delegate
        public static void CallDel()
        {
            myAction.Invoke();
        }
    }
}
