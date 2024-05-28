namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void IsAplicableTest()
        {
            var target = new PartnerDiscountAccessor();
            var order = new Order()
            {
                Customer = "Gopas",
                Price = 100,
                Product = "Test",
                Quantity = 10
            };
            target.Handle(order);
            Assert.Equal(90, order.Price);
        }

        [Fact]
        public void PrivateTest() {
            var target = new PartnerDiscountAccessor();
            Assert.Equal(42, target.DummyMethodAccessor()); 
        }
    }
    
}