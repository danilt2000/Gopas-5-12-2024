using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    public class VolumeDiscount : Discount
    {
        protected override void Apply(Order order)
        {
            order.Price -= 100;
        }

        protected override bool IsAplicable(Order order)
        {
            return order.Quantity > 99;
        }
    }
}
