using System.Diagnostics;

namespace _001_Example03_Disposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var timer = new OperationTimer())
            {
                for (int i = 0; i < 10000000; i++) ;
                //throw new Exception();
            }
        }
    }
    public class OperationTimer : IDisposable
    {
        private readonly Stopwatch _sw = new();
        private bool disposed = false;

        public OperationTimer()
        {
            _sw.Start();
        }

        ~OperationTimer()
        {
            Dispose(disposing:false);
        }

        public void Dispose()
        {
            Dispose(disposing:true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)//check it is called by GC or by user, if it is called by user then do the following
                {
                    _sw.Stop();
                    var elapsed = _sw.ElapsedMilliseconds;
                    if (elapsed > 10)
                        Console.WriteLine($"Warning: {elapsed}ms");
                }

                //release(clean up) unmanaged resources

                disposed = true;
            }
        }
    }
}
