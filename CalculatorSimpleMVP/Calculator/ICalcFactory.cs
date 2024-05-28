using Calculator.Models;

namespace Calculator
{
    public interface ICalcFactory
    {
        ICalc GetCalc();
    }
}