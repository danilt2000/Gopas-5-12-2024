namespace IoCDemo
{
    public class NewCalc : ICalc
    {
        public double Result { get; private set; }

        public void Plus(double x)
        {
            Result += x + 1;
        }
    }
}
