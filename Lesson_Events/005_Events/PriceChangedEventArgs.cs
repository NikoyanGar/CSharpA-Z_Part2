namespace _005_Events;

//Goal: show the standard pattern that supports inheritance.
class PriceChangedEventArgs : EventArgs
{
    public decimal OldPrice { get; }
    public decimal NewPrice { get; }
    public PriceChangedEventArgs(decimal oldPrice, decimal newPrice)
    { OldPrice = oldPrice; NewPrice = newPrice; }
}
