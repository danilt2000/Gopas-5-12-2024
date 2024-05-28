using System.Reflection;

namespace TestProject1
{
    public class PartnerDiscountAccessor : PartnerDiscount
    {
        public void IsAplicableAccessor(Order order)
        {
            this.IsAplicable(order);
        }

        public int DummyMethodAccessor()
        {
            Type t = typeof(PartnerDiscount);
            MethodInfo? method = t.GetMethod("DummyMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            return (int)method.Invoke(this, new object[] { });
        }
    }
}
