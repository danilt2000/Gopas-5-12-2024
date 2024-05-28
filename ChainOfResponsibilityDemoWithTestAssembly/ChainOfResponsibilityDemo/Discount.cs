
public abstract class Discount : IDiscount
{
    public IDiscount? Next { get; set; }
    public void Handle(Order order)
    {
        if (IsAplicable(order)) Apply(order);
        else if (Next != null) Next.Handle(order);
    }

    protected abstract void Apply(Order order);
    protected abstract bool IsAplicable(Order order);
}