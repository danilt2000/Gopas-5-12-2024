namespace AdapterAndBridgeDemo
{
    public class CalcClient
    {
        private ICalc calc;

        public CalcClient(ICalc calc)
        {
            this.calc = calc;
        }

        public void UseCalc()
        {
            Console.WriteLine(calc.Plus(1, 2));
        }
    }
}
