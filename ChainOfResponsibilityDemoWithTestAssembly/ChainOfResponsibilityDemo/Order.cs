public class Order
{
    public string Customer { get; set; }
    public string Product { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public override string ToString() => $"{Customer} {Product} {Quantity} {Price}";
}