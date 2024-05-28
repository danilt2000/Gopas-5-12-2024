namespace CommandProcessorDemo
{
    public class Facade : IFacade
    {
        private ICalc calc;
        private ILog log;

        public Facade(ICalc calc, ILog log)
        {
            this.calc = calc;
            this.log = log;
        }

        public void Plus(double x)
        {
            var prevResult = calc.Result;
            calc.Plus(x);
            log.Write($"{prevResult}+{x}={calc.Result}");
        }

        public void Minus(double x)
        {
            var prevResult = calc.Result;
            calc.Minus(x);
            log.Write($"{prevResult}-{x}={calc.Result}");
        }

        public void RemoveLastLogMessage()
        {
            log.RemoveLastMessage();
        }

        public double Result => calc.Result;
        public IEnumerable<string> LogItems => log.Items;
    }
}
