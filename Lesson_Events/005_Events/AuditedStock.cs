namespace _005_Events;

class AuditedStock : Stock
{
    protected override void OnPriceChanged(PriceChangedEventArgs e)
    {
        Console.WriteLine($"[Audit] {e.OldPrice} -> {e.NewPrice}");
        //OnXxx centralizes raising logic and lets subclasses inject behavior.
        //Always call base.OnXxx(e) to not “swallow” the event.
        base.OnPriceChanged(e); // keep raising the event
    }
}
