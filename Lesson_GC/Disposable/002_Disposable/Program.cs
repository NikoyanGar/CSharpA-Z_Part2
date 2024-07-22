namespace _002_Disposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ex = new Example();

            try
            {
                ex.SayHello();
            }
            finally
            {
                if (ex is IDisposable && ex != null)
                {
                    ex.Dispose();
                }
            }

            Console.WriteLine("Done");
        }
    }

    public class Example : IDisposable
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose called");
        }
    }
}
