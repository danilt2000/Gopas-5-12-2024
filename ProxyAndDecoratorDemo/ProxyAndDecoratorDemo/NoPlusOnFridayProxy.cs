namespace ProxyAndDecoratorDemo
{
    public class NoPlusOnFridayProxy : ICalc
    {
        private ICalc _calc;
        public NoPlusOnFridayProxy(ICalc calc)
        {
            _calc = calc;
        }

        public double Result => _calc.Result;

        public void Plus(double x)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday) throw new Exception("No plus on friday");
            _calc.Plus(x);
        }
    }
}
