using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndDecoratorDemo
{
    public class LoggingDecorator : ICalc
    {
        private ICalc calc;

        public LoggingDecorator(ICalc calc)
        {
            this.calc = calc;
        }

        public double Result => calc.Result;

        public void Plus(double x)
        {
            var prevResult = calc.Result;
            calc.Plus(x);
            Console.WriteLine($"LOG: {prevResult}+{x}={calc.Result}");
        }
    }
}
