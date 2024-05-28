public class PartnerDiscount : Discount
{
    public PartnerDiscount()
    {
    }

    protected override void Apply(Order order)
    {
        order.Price *= .9;
    }

    protected override bool IsAplicable(Order order)
    {
        return order.Customer == "Gopas";
    }

    private int DummyMethod() { return 42; }
}