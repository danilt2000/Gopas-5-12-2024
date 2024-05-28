using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndDecoratorDemo
{
    public class Client
    {
        private ICalc calc;

        public Client(ICalc calc)
        {
            this.calc = calc;
        }

        public void UseCalc()
        {
            calc.Plus(1.1);
            calc.Plus(2.2);
            Console.WriteLine(calc.Result);
        }
    }
}
