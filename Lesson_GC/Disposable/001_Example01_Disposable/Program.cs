using System.Diagnostics;

internal class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < 10000000; i++);
        sw.Stop();
        var elapsed = sw.ElapsedMilliseconds;
        if (elapsed > 10)
          Console.WriteLine($"Warning: {elapsed}ms");
    }
}
