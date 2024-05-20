using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCDemo
{
    public class CalcClient
    {
        private readonly ICalc calc;

        public CalcClient(ICalc calc)
        {
            this.calc = calc;
        }

        public void UseCalc()
        {
            calc.Plus(1);
            calc.Plus(2);
            Console.WriteLine(calc.Result);
        }
    }
}
