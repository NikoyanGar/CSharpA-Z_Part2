namespace _006_Events;
//6) Async handlers: pitfall & a safer pattern
//Goal: show why async void handlers can be tricky and how to await all subscribers.
using System;
using System.Drawing;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Worker
{
    public event EventHandler? Completed;

    public async Task DoWorkAsync()
    {
        await Task.Delay(200);
        Completed?.Invoke(this, EventArgs.Empty); // publisher cannot await handlers
        Console.WriteLine("Publisher moved on (handlers may still run).");
    }
}

class Program
{
    static async Task Main()
    {
        var w = new Worker();
        w.Completed += async (s, e) =>
        {
            await Task.Delay(500);
            Console.WriteLine("Slow handler done.");
        };

        await w.DoWorkAsync();
        Console.WriteLine("Main done.");
        Console.ReadLine();
    }
}
//Key points
//EventHandler can point to async void methods → caller can’t await them.
//Ordering and error handling become unclear.

