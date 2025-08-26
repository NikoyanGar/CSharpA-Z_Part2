using System;

namespace _005_Events;
//5) The recommended raise pattern — protected virtual OnXxx
//Goal: show the standard pattern that supports inheritance.
class Program
{
    static void Main()
    {
        var s = new AuditedStock();
        s.PriceChanged += (sdr, e) => Console.WriteLine($"Handler saw: {e.NewPrice}");
        s.Price = 10m;
        s.Price = 14.5m;
    }
}

//Key points
//Try it
//Add validation: block negative prices before raising.
