namespace AdapterAndBridgeDemo
{
    public class CalcAdapter : ICalc
    {
        public int Plus(int x, int y)
        {
            var calc = new Calculator();
            calc.Plus(x);
            calc.Plus(y);
            return calc.Result;
        }
    }
}
