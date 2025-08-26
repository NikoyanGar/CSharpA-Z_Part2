namespace _005_Events;

class Stock
{
    public event EventHandler<PriceChangedEventArgs>? PriceChanged;

    private decimal _price;
    public decimal Price
    {
        get => _price;
        set
        {
            if (value == _price) return;
            var old = _price;
            _price = value;
            OnPriceChanged(new PriceChangedEventArgs(old, _price)); // 3) raise via method
        }
    }

    // 2) overridable raiser
    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        => PriceChanged?.Invoke(this, e); // 1) null-safe invoke
}
