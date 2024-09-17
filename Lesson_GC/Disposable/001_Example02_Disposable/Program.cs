using System.Diagnostics;
using System.Net;
using System.Resources;

namespace _001_Example02_Disposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
           using(var timer = new OperationTimer())
           {
               for (int i = 0; i < 10000000; i++);
               //throw new Exception();
           }
        }
    }
    public class OperationTimer : IDisposable
    {
        private readonly Stopwatch _sw = new();

        public OperationTimer()
        {
            _sw.Start();
        }
        //The purpose of the Dispose method is to release any resources that the OperationTimer object is holding onto.
        //The Dispose method is typically used to clean up unmanaged resources,
        //such as file handles, network connections, or database connections.
        //It allows the object to release these resources explicitly when they are no longer needed,
        //rather than relying on the garbage collector to do it automatically.
        public void Dispose()
        {
            _sw.Stop();
            var elapsed = _sw.ElapsedMilliseconds;
            if (elapsed > 10)
                Console.WriteLine($"Warning: {elapsed}ms");
        }
    }
}
