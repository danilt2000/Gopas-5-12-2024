public interface IDiscount
{
    IDiscount? Next { get; set; }

    void Handle(Order order);
}