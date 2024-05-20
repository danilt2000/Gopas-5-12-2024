namespace IoCDemo
{
    public class Calc : ICalc
    {
        public double Result { get; private set; }
        public void Plus(double x) { Result += x; }
    }
}
