using Calculator.Models;

namespace Calculator
{
    public class CalcFactory : ICalcFactory
    {
        private Lazy<Calc> calc = new Lazy<Calc>();
        public ICalc GetCalc() => calc.Value;
    }
}
