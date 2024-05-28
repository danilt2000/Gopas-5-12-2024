namespace ProxyAndDecoratorDemo
{
    public class RoundingProxy : ICalc
    {
        private readonly ICalc _calc;

        public RoundingProxy(Calc calc)
        {
            _calc = calc;
        }

        public double Result => Math.Round(_calc.Result);

        public void Plus(double x)
        {
            _calc.Plus(Math.Round(x));
        }
    }
}
